﻿/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO.Compression;

using Hubble.Core.SFQL.Parse;


namespace QueryAnalyzer
{
    public partial class FormPerformance : Form
    {
        internal DbAccess DataAccess { get; set; }

        public FormPerformance()
        {
            InitializeComponent();
        }


        private void ShowErrorMessage(string err)
        {
            MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void buttonTest_Click(object sender, EventArgs e)
        {
            try
            {
                QueryPerfCounter qp = new QueryPerfCounter();

                bool dataCacheEnabled = checkBoxDataCache.Checked;
                
                int dataCacheTimeout = -1;

                if (dataCacheEnabled)
                {
                    dataCacheTimeout = (int)numericUpDownDataCache.Value;
                }

                qp.Start();

                SFQLParse sfqlParse = new SFQLParse();
                string sql = textBoxSql.Text;

                if (!string.IsNullOrEmpty(textBoxSql.SelectedText))
                {
                    sql = textBoxSql.SelectedText;
                }

                for (int i = 0; i < numericUpDownIteration.Value; i++)
                {
                    if (dataCacheEnabled)
                    {
                        DataAccess.Excute(sql, dataCacheTimeout);
                    }
                    else
                    {
                        DataAccess.Excute(sql);
                    }
                }

                qp.Stop();
                double ns = qp.Duration(1);

                StringBuilder report = new StringBuilder();

                report.AppendFormat("{0} ", (ns / ((long)1000 * (long)1000 * (int)numericUpDownIteration.Value)).ToString("0.00") + " ms");

                labelDuration.Text = report.ToString();

            }
            catch (Hubble.Core.SFQL.LexicalAnalysis.LexicalException lexicalEx)
            {
                ShowErrorMessage(lexicalEx.ToString());
            }
            catch (Hubble.Core.SFQL.SyntaxAnalysis.SyntaxException syntaxEx)
            {
                ShowErrorMessage(syntaxEx.ToString());
            }
            catch (Exception e1)
            {
                ShowErrorMessage(e1.Message + "\r\n" + e1.StackTrace);
            }
            finally
            {
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private MemoryStream Serialize(Hubble.SQLClient.QueryResult result, bool compress)
        {
            MemoryStream m = new MemoryStream();

            //Hubble.SQLClient.QueryResultSerialization.Serialize(m, result, compress);

            m.Position = 0;

            return m;
        }

        private MemoryStream Compress(MemoryStream m)
        {
            MemoryStream cm = new MemoryStream();
            MemoryStream result = new MemoryStream();

            using (GZipStream g = new GZipStream(result, CompressionMode.Compress, true))
            {
                byte[] buf = m.GetBuffer();

                g.Write(buf, 0, (int)m.Length);

                //result.Write(cm.GetBuffer(), 0, (int)cm.Length);
            }

            return result;
        }

        private MemoryStream DeCompress(MemoryStream m)
        {
            MemoryStream result = new MemoryStream();

            using (GZipStream g = new GZipStream(m, CompressionMode.Decompress))
            {
                byte[] buf = m.GetBuffer();

                // Use this method is used to read all bytes from a stream.

                byte[] buffer = new byte[4096]; 

                while (true)
                {
                    int bytesRead = g.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        break;
                    }

                    result.Write(buffer, 0, bytesRead);
                }
            }

            return result;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                QueryPerfCounter qp = new QueryPerfCounter();

                SFQLParse sfqlParse = new SFQLParse();
                string sql = textBoxSql.Text;

                if (!string.IsNullOrEmpty(textBoxSql.SelectedText))
                {
                    sql = textBoxSql.SelectedText;
                }

                Hubble.SQLClient.QueryResult result = DataAccess.Excute(sql);

                qp.Start();

                for (int i = 0; i < numericUpDownIteration.Value; i++)
                {
                    //MemoryStream s = Serialize(result, true);

                    //Hubble.SQLClient.QueryResult r =
                    //    Hubble.SQLClient.QueryResultSerialization.Deserialize(s, true);

                    //if (result.DataSet.Tables.Count == r.DataSet.Tables.Count)
                    //{
                    //    MessageBox.Show("OK");
                    //}

                    //len = s.Length;
                    //MemoryStream s = Hubble.Framework.Serialization.XmlSerialization<Hubble.SQLClient.QueryResult>.Serialize(result, Encoding.UTF8);


                    //MemoryStream s = new MemoryStream();
                    //IFormatter formatter = new BinaryFormatter();
                    //formatter.Serialize(s, result);
                    //s.Position = 0;
                    //len = s.Length;

                    //MemoryStream cs = Compress(s);
                    //cs.Position = 0;
                    //cs = DeCompress(cs);
                    //cs.Position = 0;
                    //formatter = new BinaryFormatter();
                    //formatter.Deserialize(s);

                    //Hubble.Framework.Serialization.XmlSerialization<Hubble.SQLClient.QueryResult>.Deserialize(cs);
                }

                qp.Stop();
                double ns = qp.Duration(1);

                StringBuilder report = new StringBuilder();

                report.AppendFormat("{0} ", (ns / (1000 * 1000 * (int)numericUpDownIteration.Value)).ToString("0.00") + " ms");

                labelDuration.Text = report.ToString();

            }
            catch (Hubble.Core.SFQL.LexicalAnalysis.LexicalException lexicalEx)
            {
                ShowErrorMessage(lexicalEx.ToString());
            }
            catch (Hubble.Core.SFQL.SyntaxAnalysis.SyntaxException syntaxEx)
            {
                ShowErrorMessage(syntaxEx.ToString());
            }
            catch (Exception e1)
            {
                ShowErrorMessage(e1.Message + "\r\n" + e1.StackTrace);
            }
            finally
            {
            }
        }

        private void checkBoxDataCache_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxDataCache.Enabled = checkBoxDataCache.Checked;
        }

        private void FormPerformance_Load(object sender, EventArgs e)
        {
            int left = groupBoxDataCache.Left + checkBoxDataCache.Left;
            int top = groupBoxDataCache.Top + checkBoxDataCache.Top;

            checkBoxDataCache.Parent = this;
            checkBoxDataCache.Location = new Point(left, top);
            checkBoxDataCache.BringToFront();
        }
    }
}
