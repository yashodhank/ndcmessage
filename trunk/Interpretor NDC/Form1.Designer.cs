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
            this.listBoxMessageIn = new System.Windows.Forms.ListBox();
            this.textBoxMessageIn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(44, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(144, 23);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Analyse MessageIn.log";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // openFileDialogMessageIn
            // 
            this.openFileDialogMessageIn.Filter = "LOG (*.log)|*.log|All files (*.*)|*.*\"";
            // 
            // listBoxMessageIn
            // 
            this.listBoxMessageIn.FormattingEnabled = true;
            this.listBoxMessageIn.Location = new System.Drawing.Point(12, 41);
            this.listBoxMessageIn.Name = "listBoxMessageIn";
            this.listBoxMessageIn.Size = new System.Drawing.Size(62, 212);
            this.listBoxMessageIn.TabIndex = 1;
            this.listBoxMessageIn.SelectedIndexChanged += new System.EventHandler(this.listBoxMessageIn_SelectedIndexChanged);
            // 
            // textBoxMessageIn
            // 
            this.textBoxMessageIn.Location = new System.Drawing.Point(80, 41);
            this.textBoxMessageIn.Multiline = true;
            this.textBoxMessageIn.Name = "textBoxMessageIn";
            this.textBoxMessageIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessageIn.Size = new System.Drawing.Size(150, 211);
            this.textBoxMessageIn.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.textBoxMessageIn);
            this.Controls.Add(this.listBoxMessageIn);
            this.Controls.Add(this.buttonOpenFile);
            this.Name = "Form1";
            this.Text = "Analizator NDC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogMessageIn;
        private System.Windows.Forms.ListBox listBoxMessageIn;
        private System.Windows.Forms.TextBox textBoxMessageIn;
    }
}

