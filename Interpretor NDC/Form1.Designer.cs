namespace Interpretor_NDC
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
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.openFileDialogMessageIn = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewMessageIn = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessageIn)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(13, 13);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(105, 23);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "OpenFileToSplit";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // openFileDialogMessageIn
            // 
            this.openFileDialogMessageIn.Filter = "LOG (*.log)|*.log|All files (*.*)|*.*\"";
            // 
            // dataGridViewMessageIn
            // 
            this.dataGridViewMessageIn.AllowUserToAddRows = false;
            this.dataGridViewMessageIn.AllowUserToDeleteRows = false;
            this.dataGridViewMessageIn.AllowUserToResizeRows = false;
            this.dataGridViewMessageIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMessageIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3});
            this.dataGridViewMessageIn.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewMessageIn.Name = "dataGridViewMessageIn";
            this.dataGridViewMessageIn.ReadOnly = true;
            this.dataGridViewMessageIn.Size = new System.Drawing.Size(343, 153);
            this.dataGridViewMessageIn.TabIndex = 1;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "Nr";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "Type";
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            // 
            // Col3
            // 
            this.Col3.HeaderText = "Message";
            this.Col3.Name = "Col3";
            this.Col3.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.dataGridViewMessageIn);
            this.Controls.Add(this.buttonOpenFile);
            this.Name = "Form1";
            this.Text = "Analizator NDC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessageIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogMessageIn;
        private System.Windows.Forms.DataGridView dataGridViewMessageIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
    }
}

