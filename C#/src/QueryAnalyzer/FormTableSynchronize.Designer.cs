﻿namespace QueryAnalyzer
{
    partial class FormTableSynchronize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTableName = new System.Windows.Forms.Label();
            this.numericUpDownStep = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOptimizeOption = new System.Windows.Forms.ComboBox();
            this.labelProgress = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelInsertRows = new System.Windows.Forms.Label();
            this.labelElapse = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxFastestMode = new System.Windows.Forms.CheckBox();
            this.groupBoxFlags = new System.Windows.Forms.GroupBox();
            this.checkBoxNoLock = new System.Windows.Forms.CheckBox();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.checkBoxUpdate = new System.Windows.Forms.CheckBox();
            this.checkBoxInsert = new System.Windows.Forms.CheckBox();
            this.buttonViewScript = new System.Windows.Forms.Button();
            this.textBoxScript = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep)).BeginInit();
            this.groupBoxFlags.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(17, 172);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(547, 60);
            this.progressBar.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(17, 238);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Table name:";
            // 
            // labelTableName
            // 
            this.labelTableName.AutoSize = true;
            this.labelTableName.Location = new System.Drawing.Point(130, 14);
            this.labelTableName.Name = "labelTableName";
            this.labelTableName.Size = new System.Drawing.Size(66, 13);
            this.labelTableName.TabIndex = 3;
            this.labelTableName.Text = "Table name:";
            // 
            // numericUpDownStep
            // 
            this.numericUpDownStep.Location = new System.Drawing.Point(133, 34);
            this.numericUpDownStep.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStep.Name = "numericUpDownStep";
            this.numericUpDownStep.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownStep.TabIndex = 22;
            this.numericUpDownStep.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Step";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Optimize option";
            // 
            // comboBoxOptimizeOption
            // 
            this.comboBoxOptimizeOption.FormattingEnabled = true;
            this.comboBoxOptimizeOption.Items.AddRange(new object[] {
            "Minimum",
            "Middle",
            "None"});
            this.comboBoxOptimizeOption.Location = new System.Drawing.Point(132, 61);
            this.comboBoxOptimizeOption.Name = "comboBoxOptimizeOption";
            this.comboBoxOptimizeOption.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOptimizeOption.TabIndex = 24;
            this.comboBoxOptimizeOption.Text = "Minimum";
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgress.Location = new System.Drawing.Point(570, 190);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(43, 25);
            this.labelProgress.TabIndex = 25;
            this.labelProgress.Text = "0%";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(105, 238);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 26;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Insert rows:";
            // 
            // labelInsertRows
            // 
            this.labelInsertRows.AutoSize = true;
            this.labelInsertRows.Location = new System.Drawing.Point(358, 243);
            this.labelInsertRows.Name = "labelInsertRows";
            this.labelInsertRows.Size = new System.Drawing.Size(13, 13);
            this.labelInsertRows.TabIndex = 28;
            this.labelInsertRows.Text = "0";
            // 
            // labelElapse
            // 
            this.labelElapse.AutoSize = true;
            this.labelElapse.Location = new System.Drawing.Point(552, 243);
            this.labelElapse.Name = "labelElapse";
            this.labelElapse.Size = new System.Drawing.Size(13, 13);
            this.labelElapse.TabIndex = 30;
            this.labelElapse.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Elapse:";
            // 
            // checkBoxFastestMode
            // 
            this.checkBoxFastestMode.AutoSize = true;
            this.checkBoxFastestMode.Location = new System.Drawing.Point(17, 97);
            this.checkBoxFastestMode.Name = "checkBoxFastestMode";
            this.checkBoxFastestMode.Size = new System.Drawing.Size(90, 17);
            this.checkBoxFastestMode.TabIndex = 31;
            this.checkBoxFastestMode.Text = "Fastest Mode";
            this.checkBoxFastestMode.UseVisualStyleBackColor = true;
            // 
            // groupBoxFlags
            // 
            this.groupBoxFlags.Controls.Add(this.checkBoxNoLock);
            this.groupBoxFlags.Controls.Add(this.checkBoxDelete);
            this.groupBoxFlags.Controls.Add(this.checkBoxUpdate);
            this.groupBoxFlags.Controls.Add(this.checkBoxInsert);
            this.groupBoxFlags.Location = new System.Drawing.Point(293, 14);
            this.groupBoxFlags.Name = "groupBoxFlags";
            this.groupBoxFlags.Size = new System.Drawing.Size(271, 152);
            this.groupBoxFlags.TabIndex = 32;
            this.groupBoxFlags.TabStop = false;
            this.groupBoxFlags.Text = "Flags";
            // 
            // checkBoxNoLock
            // 
            this.checkBoxNoLock.AutoSize = true;
            this.checkBoxNoLock.Location = new System.Drawing.Point(6, 89);
            this.checkBoxNoLock.Name = "checkBoxNoLock";
            this.checkBoxNoLock.Size = new System.Drawing.Size(64, 17);
            this.checkBoxNoLock.TabIndex = 3;
            this.checkBoxNoLock.Text = "NoLock";
            this.checkBoxNoLock.UseVisualStyleBackColor = true;
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.AutoSize = true;
            this.checkBoxDelete.Checked = true;
            this.checkBoxDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDelete.Location = new System.Drawing.Point(6, 66);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(57, 17);
            this.checkBoxDelete.TabIndex = 2;
            this.checkBoxDelete.Text = "Delete";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpdate
            // 
            this.checkBoxUpdate.AutoSize = true;
            this.checkBoxUpdate.Checked = true;
            this.checkBoxUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUpdate.Location = new System.Drawing.Point(6, 43);
            this.checkBoxUpdate.Name = "checkBoxUpdate";
            this.checkBoxUpdate.Size = new System.Drawing.Size(61, 17);
            this.checkBoxUpdate.TabIndex = 1;
            this.checkBoxUpdate.Text = "Update";
            this.checkBoxUpdate.UseVisualStyleBackColor = true;
            // 
            // checkBoxInsert
            // 
            this.checkBoxInsert.AutoSize = true;
            this.checkBoxInsert.Checked = true;
            this.checkBoxInsert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInsert.Location = new System.Drawing.Point(6, 20);
            this.checkBoxInsert.Name = "checkBoxInsert";
            this.checkBoxInsert.Size = new System.Drawing.Size(52, 17);
            this.checkBoxInsert.TabIndex = 0;
            this.checkBoxInsert.Text = "Insert";
            this.checkBoxInsert.UseVisualStyleBackColor = true;
            // 
            // buttonViewScript
            // 
            this.buttonViewScript.Location = new System.Drawing.Point(197, 238);
            this.buttonViewScript.Name = "buttonViewScript";
            this.buttonViewScript.Size = new System.Drawing.Size(75, 23);
            this.buttonViewScript.TabIndex = 33;
            this.buttonViewScript.Text = "View Script";
            this.buttonViewScript.UseVisualStyleBackColor = true;
            this.buttonViewScript.Click += new System.EventHandler(this.buttonViewScript_Click);
            // 
            // textBoxScript
            // 
            this.textBoxScript.Location = new System.Drawing.Point(17, 268);
            this.textBoxScript.Multiline = true;
            this.textBoxScript.Name = "textBoxScript";
            this.textBoxScript.Size = new System.Drawing.Size(548, 105);
            this.textBoxScript.TabIndex = 34;
            // 
            // FormTableSynchronize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 264);
            this.Controls.Add(this.textBoxScript);
            this.Controls.Add(this.buttonViewScript);
            this.Controls.Add(this.groupBoxFlags);
            this.Controls.Add(this.checkBoxFastestMode);
            this.Controls.Add(this.labelElapse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelInsertRows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.comboBoxOptimizeOption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownStep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.progressBar);
            this.Name = "FormTableSynchronize";
            this.Text = "Table Synchronize";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep)).EndInit();
            this.groupBoxFlags.ResumeLayout(false);
            this.groupBoxFlags.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTableName;
        private System.Windows.Forms.NumericUpDown numericUpDownStep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOptimizeOption;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelInsertRows;
        private System.Windows.Forms.Label labelElapse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxFastestMode;
        private System.Windows.Forms.GroupBox groupBoxFlags;
        private System.Windows.Forms.CheckBox checkBoxNoLock;
        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.CheckBox checkBoxUpdate;
        private System.Windows.Forms.CheckBox checkBoxInsert;
        private System.Windows.Forms.Button buttonViewScript;
        private System.Windows.Forms.TextBox textBoxScript;
    }
}