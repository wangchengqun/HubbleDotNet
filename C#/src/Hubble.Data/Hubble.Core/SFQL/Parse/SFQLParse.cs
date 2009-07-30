﻿using System;
using System.Collections.Generic;
using System.Text;

using Hubble.Core.SFQL.LexicalAnalysis;
using Hubble.Core.SFQL.SyntaxAnalysis;
using Hubble.Framework.DataStructure;

namespace Hubble.Core.SFQL.Parse
{
    public class SFQLParse
    {
        List<TSFQLSentence> _SFQLSentenceList;
        TSFQLSentence _SFQLSentence;

        public int Begin = 0;
        public int End = 99;

        private void InputLexicalToken(Lexical.Token token)
        {
            if (token.SyntaxType == SyntaxType.Space)
            {
                return;
            }

            if (_SFQLSentence == null)
            {
                _SFQLSentence = new TSFQLSentence();
            }

            DFAResult result = _SFQLSentence.Input((int)token.SyntaxType, token);

            switch (result)
            {
                case DFAResult.Quit:
                case DFAResult.ElseQuit:
                    _SFQLSentenceList.Add(_SFQLSentence);
                    _SFQLSentence = null;
                    break;
            }

        }

        private void SyntaxAnalyse(string text)
        {
            Lexical lexical = new Lexical(text);

            DFAResult dfaResult;

            for (int i = 0; i < text.Length; i++)
            {
                dfaResult = lexical.Input(text[i], i);

                switch (dfaResult)
                {
                    case DFAResult.Continue:
                        continue;
                    case DFAResult.Quit:
                        InputLexicalToken(lexical.OutputToken);
                        break;
                    case DFAResult.ElseQuit:
                        InputLexicalToken(lexical.OutputToken);
                        i--;
                        break;
                }

            }


            dfaResult = lexical.Input(0, text.Length);

            switch (dfaResult)
            {
                case DFAResult.Continue:
                    throw new Hubble.Core.SFQL.LexicalAnalysis.LexicalException("Lexical abort at the end of sql");
                case DFAResult.Quit:
                    InputLexicalToken(lexical.OutputToken);
                    break;
                case DFAResult.ElseQuit:
                    InputLexicalToken(lexical.OutputToken);
                    break;
            }

            InputLexicalToken(new Lexical.Token());

        }

        private QueryResult ExcuteSelect(TSFQLSentence sentence)
        {
            SyntaxAnalysis.Select.Select select = sentence.SyntaxEntity as
                SyntaxAnalysis.Select.Select;

            ParseWhere parseWhere = new ParseWhere(select.SelectFroms[0].Name);

            parseWhere.Begin = this.Begin;
            parseWhere.End = this.End;
            Query.DocumentResult[] result = parseWhere.Parse((sentence.SyntaxEntity as
                SyntaxAnalysis.Select.Select).Where.ExpressionTree);

            //Sort
            Data.DBProvider dBProvider =  Data.DBProvider.GetDBProvider(select.SelectFroms[0].Name);

            QueryResultSort qSort = new QueryResultSort(select.OrderBys, dBProvider);
            qSort.Sort(result);

            List<Data.Field> selectFields = new List<Data.Field>();
            

            foreach (SyntaxAnalysis.Select.SelectField selectField in select.SelectFields)
            {
                Data.Field field = dBProvider.GetField(selectField.Name);

                if (field == null)
                {

                    if (selectField.Name.Equals("DocId", StringComparison.CurrentCultureIgnoreCase))
                    {
                        selectFields.Add(new Data.Field("DocId", Hubble.Core.Data.DataType.Int64));
                    }
                    else if (selectField.Name.Equals("Score", StringComparison.CurrentCultureIgnoreCase))
                    {
                        selectFields.Add(new Data.Field("Score", Hubble.Core.Data.DataType.Int64));
                    }
                    else
                    {
                        throw new ParseException(string.Format("Unknown field name:{0}", selectField.Name));
                    }
                }
                else
                {
                    selectFields.Add(field);
                }
            }

            List<Data.Document> docResult = dBProvider.Query(selectFields, result, Begin, End);
            System.Data.DataSet ds = Data.Document.ToDataSet(selectFields, docResult);
            ds.Tables[0].TableName = select.SelectFroms[0].Name;

            for (int i = 0; i < select.SelectFields.Count; i++)
            {
                ds.Tables[0].Columns[i].ColumnName = select.SelectFields[i].Alias;
            }
            
            ds.Tables[0].MinimumCapacity = result.Length;

            return new QueryResult(ds);
        }

        private QueryResult ExecuteTSFQLSentence(TSFQLSentence sentence)
        {
            ParseOptimize pOptimize = new ParseOptimize();
            sentence = pOptimize.Optimize(sentence);

            switch (sentence.SentenceType)
            {
                case SentenceType.SELECT:
                    return ExcuteSelect(sentence);
            }

            return null;
        }


        public void ExecuteNonQuery(string sql)
        {
            Query(sql);
        }

        public QueryResult Query(string sql)
        {
            _SFQLSentenceList = new List<TSFQLSentence>();

            QueryResult result = new QueryResult();

            SyntaxAnalyse(sql);

            foreach (TSFQLSentence sentence in _SFQLSentenceList)
            {
                QueryResult queryResult = ExecuteTSFQLSentence(sentence);

                if (queryResult != null)
                {
                    List<System.Data.DataTable> tables = new List<System.Data.DataTable>();

                    foreach (System.Data.DataTable table in queryResult.DataSet.Tables)
                    {
                        tables.Add(table);
                    }

                    foreach (System.Data.DataTable table in tables)
                    {
                        queryResult.DataSet.Tables.Remove(table);
                    }

                    foreach (System.Data.DataTable table in tables)
                    {
                        result.DataSet.Tables.Add(table);
                    }
                }
            }

            return result;
        }
    }
}