namespace Word_Analyser
{
    partial class Form1
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numofWords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numofSentences = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgWordLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numWordinSent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semicolons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmpSent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.AcceptsReturn = true;
            this.inputBox.AcceptsTab = true;
            this.inputBox.Location = new System.Drawing.Point(12, 12);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(416, 371);
            this.inputBox.TabIndex = 0;
            this.inputBox.Text = "(Insert text here)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Analyze";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.numofWords,
            this.numofSentences,
            this.avgWordLength,
            this.numWordinSent,
            this.semicolons,
            this.colons,
            this.CmpSent});
            this.table.Location = new System.Drawing.Point(434, 12);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 50;
            this.table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(994, 219);
            this.table.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "Article Name";
            this.id.Name = "id";
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 125;
            // 
            // numofWords
            // 
            this.numofWords.HeaderText = "Number of Words";
            this.numofWords.Name = "numofWords";
            this.numofWords.ReadOnly = true;
            this.numofWords.Width = 125;
            // 
            // numofSentences
            // 
            this.numofSentences.HeaderText = "Number of Sentences";
            this.numofSentences.Name = "numofSentences";
            this.numofSentences.ReadOnly = true;
            this.numofSentences.Width = 125;
            // 
            // avgWordLength
            // 
            this.avgWordLength.HeaderText = "Average Word Length";
            this.avgWordLength.Name = "avgWordLength";
            this.avgWordLength.ReadOnly = true;
            this.avgWordLength.Width = 125;
            // 
            // numWordinSent
            // 
            this.numWordinSent.HeaderText = "Average Number of Words in a Sentence";
            this.numWordinSent.Name = "numWordinSent";
            this.numWordinSent.ReadOnly = true;
            this.numWordinSent.Width = 125;
            // 
            // semicolons
            // 
            this.semicolons.HeaderText = "Number of Semicolons";
            this.semicolons.Name = "semicolons";
            this.semicolons.ReadOnly = true;
            // 
            // colons
            // 
            this.colons.HeaderText = "Number of Colons";
            this.colons.Name = "colons";
            this.colons.ReadOnly = true;
            // 
            // CmpSent
            // 
            this.CmpSent.HeaderText = "Number of Compound Sentences";
            this.CmpSent.Name = "CmpSent";
            this.CmpSent.ReadOnly = true;
            this.CmpSent.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 445);
            this.Controls.Add(this.table);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputBox);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Word Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn numofWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn numofSentences;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgWordLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn numWordinSent;
        private System.Windows.Forms.DataGridViewTextBoxColumn semicolons;
        private System.Windows.Forms.DataGridViewTextBoxColumn colons;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmpSent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

