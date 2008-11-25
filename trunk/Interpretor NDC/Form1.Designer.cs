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
            this.checkBoxTerminalCommands = new System.Windows.Forms.CheckBox();
            this.labelSplit = new System.Windows.Forms.Label();
            this.checkBoxScreenKeyboard = new System.Windows.Forms.CheckBox();
            this.checkBoxConfigurationIDNumber = new System.Windows.Forms.CheckBox();
            this.checkBoxFIT = new System.Windows.Forms.CheckBox();
            this.checkBoxConfigurationParameters = new System.Windows.Forms.CheckBox();
            this.checkBoxStateTables = new System.Windows.Forms.CheckBox();
            this.checkBoxDateAndTime = new System.Windows.Forms.CheckBox();
            this.checkBoxInteractiveTransactionResponse = new System.Windows.Forms.CheckBox();
            this.checkBoxDispencerCurrencyCassetteMapp = new System.Windows.Forms.CheckBox();
            this.checkBoxXMLConfigurationDownload = new System.Windows.Forms.CheckBox();
            this.checkBoxMACFieldSelection = new System.Windows.Forms.CheckBox();
            this.checkBox1EnhancedConfigurationParameters = new System.Windows.Forms.CheckBox();
            this.checkBoxEncryptionKeyChange = new System.Windows.Forms.CheckBox();
            this.checkBoxExtendedEncryptionKeyChange = new System.Windows.Forms.CheckBox();
            this.buttonSplitSelect = new System.Windows.Forms.Button();
            this.labelInceputMesaj = new System.Windows.Forms.Label();
            this.labelSfarsitulMesajului = new System.Windows.Forms.Label();
            this.textBoxInceputulMesajului = new System.Windows.Forms.TextBox();
            this.textBoxSfarsitulMesajului = new System.Windows.Forms.TextBox();
            this.labelSariPeste = new System.Windows.Forms.Label();
            this.textBoxSariPestePrimele = new System.Windows.Forms.TextBox();
            this.labelCaractere = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxArataLog = new System.Windows.Forms.TextBox();
            this.buttonArataLog = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 454);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(144, 23);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Analizeaza MessageIn.log";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // openFileDialogMessageIn
            // 
            this.openFileDialogMessageIn.FileName = "MessageIn.log";
            this.openFileDialogMessageIn.Filter = "LOG (*.log)|*.log|All files (*.*)|*.*\"";
            // 
            // listBoxMessageIn
            // 
            this.listBoxMessageIn.FormattingEnabled = true;
            this.listBoxMessageIn.Location = new System.Drawing.Point(6, 52);
            this.listBoxMessageIn.Name = "listBoxMessageIn";
            this.listBoxMessageIn.Size = new System.Drawing.Size(92, 212);
            this.listBoxMessageIn.TabIndex = 1;
            this.listBoxMessageIn.SelectedIndexChanged += new System.EventHandler(this.listBoxMessageIn_SelectedIndexChanged);
            // 
            // textBoxMessageIn
            // 
            this.textBoxMessageIn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxMessageIn.Location = new System.Drawing.Point(106, 52);
            this.textBoxMessageIn.Multiline = true;
            this.textBoxMessageIn.Name = "textBoxMessageIn";
            this.textBoxMessageIn.ReadOnly = true;
            this.textBoxMessageIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessageIn.Size = new System.Drawing.Size(670, 212);
            this.textBoxMessageIn.TabIndex = 2;
            // 
            // checkBoxTerminalCommands
            // 
            this.checkBoxTerminalCommands.AutoSize = true;
            this.checkBoxTerminalCommands.Location = new System.Drawing.Point(6, 298);
            this.checkBoxTerminalCommands.Name = "checkBoxTerminalCommands";
            this.checkBoxTerminalCommands.Size = new System.Drawing.Size(121, 17);
            this.checkBoxTerminalCommands.TabIndex = 3;
            this.checkBoxTerminalCommands.Text = "Terminal Commands";
            this.checkBoxTerminalCommands.UseVisualStyleBackColor = true;
            // 
            // labelSplit
            // 
            this.labelSplit.AutoSize = true;
            this.labelSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSplit.Location = new System.Drawing.Point(97, 270);
            this.labelSplit.Name = "labelSplit";
            this.labelSplit.Size = new System.Drawing.Size(170, 25);
            this.labelSplit.TabIndex = 4;
            this.labelSplit.Text = "Extract exit file";
            // 
            // checkBoxScreenKeyboard
            // 
            this.checkBoxScreenKeyboard.AutoSize = true;
            this.checkBoxScreenKeyboard.Location = new System.Drawing.Point(6, 321);
            this.checkBoxScreenKeyboard.Name = "checkBoxScreenKeyboard";
            this.checkBoxScreenKeyboard.Size = new System.Drawing.Size(110, 17);
            this.checkBoxScreenKeyboard.TabIndex = 5;
            this.checkBoxScreenKeyboard.Text = "Screen/Keyboard";
            this.checkBoxScreenKeyboard.UseVisualStyleBackColor = true;
            // 
            // checkBoxConfigurationIDNumber
            // 
            this.checkBoxConfigurationIDNumber.AutoSize = true;
            this.checkBoxConfigurationIDNumber.Location = new System.Drawing.Point(6, 413);
            this.checkBoxConfigurationIDNumber.Name = "checkBoxConfigurationIDNumber";
            this.checkBoxConfigurationIDNumber.Size = new System.Drawing.Size(142, 17);
            this.checkBoxConfigurationIDNumber.TabIndex = 6;
            this.checkBoxConfigurationIDNumber.Text = "Configuration ID Number";
            this.checkBoxConfigurationIDNumber.UseVisualStyleBackColor = true;
            // 
            // checkBoxFIT
            // 
            this.checkBoxFIT.AutoSize = true;
            this.checkBoxFIT.Location = new System.Drawing.Point(6, 390);
            this.checkBoxFIT.Name = "checkBoxFIT";
            this.checkBoxFIT.Size = new System.Drawing.Size(42, 17);
            this.checkBoxFIT.TabIndex = 7;
            this.checkBoxFIT.Text = "FIT";
            this.checkBoxFIT.UseVisualStyleBackColor = true;
            // 
            // checkBoxConfigurationParameters
            // 
            this.checkBoxConfigurationParameters.AutoSize = true;
            this.checkBoxConfigurationParameters.Location = new System.Drawing.Point(6, 367);
            this.checkBoxConfigurationParameters.Name = "checkBoxConfigurationParameters";
            this.checkBoxConfigurationParameters.Size = new System.Drawing.Size(144, 17);
            this.checkBoxConfigurationParameters.TabIndex = 8;
            this.checkBoxConfigurationParameters.Text = "Configuration Parameters";
            this.checkBoxConfigurationParameters.UseVisualStyleBackColor = true;
            // 
            // checkBoxStateTables
            // 
            this.checkBoxStateTables.AutoSize = true;
            this.checkBoxStateTables.Location = new System.Drawing.Point(6, 344);
            this.checkBoxStateTables.Name = "checkBoxStateTables";
            this.checkBoxStateTables.Size = new System.Drawing.Size(86, 17);
            this.checkBoxStateTables.TabIndex = 9;
            this.checkBoxStateTables.Text = "State Tables";
            this.checkBoxStateTables.UseVisualStyleBackColor = true;
            // 
            // checkBoxDateAndTime
            // 
            this.checkBoxDateAndTime.AutoSize = true;
            this.checkBoxDateAndTime.Location = new System.Drawing.Point(6, 481);
            this.checkBoxDateAndTime.Name = "checkBoxDateAndTime";
            this.checkBoxDateAndTime.Size = new System.Drawing.Size(96, 17);
            this.checkBoxDateAndTime.TabIndex = 15;
            this.checkBoxDateAndTime.Text = "Date and Time";
            this.checkBoxDateAndTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxInteractiveTransactionResponse
            // 
            this.checkBoxInteractiveTransactionResponse.AutoSize = true;
            this.checkBoxInteractiveTransactionResponse.Location = new System.Drawing.Point(207, 344);
            this.checkBoxInteractiveTransactionResponse.Name = "checkBoxInteractiveTransactionResponse";
            this.checkBoxInteractiveTransactionResponse.Size = new System.Drawing.Size(186, 17);
            this.checkBoxInteractiveTransactionResponse.TabIndex = 14;
            this.checkBoxInteractiveTransactionResponse.Text = "Interactive Transaction Response";
            this.checkBoxInteractiveTransactionResponse.UseVisualStyleBackColor = true;
            // 
            // checkBoxDispencerCurrencyCassetteMapp
            // 
            this.checkBoxDispencerCurrencyCassetteMapp.AutoSize = true;
            this.checkBoxDispencerCurrencyCassetteMapp.Location = new System.Drawing.Point(207, 298);
            this.checkBoxDispencerCurrencyCassetteMapp.Name = "checkBoxDispencerCurrencyCassetteMapp";
            this.checkBoxDispencerCurrencyCassetteMapp.Size = new System.Drawing.Size(206, 17);
            this.checkBoxDispencerCurrencyCassetteMapp.TabIndex = 13;
            this.checkBoxDispencerCurrencyCassetteMapp.Text = "Dispenser Currency Cassette Mapping";
            this.checkBoxDispencerCurrencyCassetteMapp.UseVisualStyleBackColor = true;
            // 
            // checkBoxXMLConfigurationDownload
            // 
            this.checkBoxXMLConfigurationDownload.AutoSize = true;
            this.checkBoxXMLConfigurationDownload.Location = new System.Drawing.Point(207, 321);
            this.checkBoxXMLConfigurationDownload.Name = "checkBoxXMLConfigurationDownload";
            this.checkBoxXMLConfigurationDownload.Size = new System.Drawing.Size(164, 17);
            this.checkBoxXMLConfigurationDownload.TabIndex = 12;
            this.checkBoxXMLConfigurationDownload.Text = "XML Configuration Download";
            this.checkBoxXMLConfigurationDownload.UseVisualStyleBackColor = true;
            // 
            // checkBoxMACFieldSelection
            // 
            this.checkBoxMACFieldSelection.AutoSize = true;
            this.checkBoxMACFieldSelection.Location = new System.Drawing.Point(6, 458);
            this.checkBoxMACFieldSelection.Name = "checkBoxMACFieldSelection";
            this.checkBoxMACFieldSelection.Size = new System.Drawing.Size(121, 17);
            this.checkBoxMACFieldSelection.TabIndex = 11;
            this.checkBoxMACFieldSelection.Text = "MAC Field Selection";
            this.checkBoxMACFieldSelection.UseVisualStyleBackColor = true;
            // 
            // checkBox1EnhancedConfigurationParameters
            // 
            this.checkBox1EnhancedConfigurationParameters.AutoSize = true;
            this.checkBox1EnhancedConfigurationParameters.Location = new System.Drawing.Point(6, 435);
            this.checkBox1EnhancedConfigurationParameters.Name = "checkBox1EnhancedConfigurationParameters";
            this.checkBox1EnhancedConfigurationParameters.Size = new System.Drawing.Size(196, 17);
            this.checkBox1EnhancedConfigurationParameters.TabIndex = 10;
            this.checkBox1EnhancedConfigurationParameters.Text = "Enhanced Configuration Parameters";
            this.checkBox1EnhancedConfigurationParameters.UseVisualStyleBackColor = true;
            // 
            // checkBoxEncryptionKeyChange
            // 
            this.checkBoxEncryptionKeyChange.AutoSize = true;
            this.checkBoxEncryptionKeyChange.Location = new System.Drawing.Point(207, 367);
            this.checkBoxEncryptionKeyChange.Name = "checkBoxEncryptionKeyChange";
            this.checkBoxEncryptionKeyChange.Size = new System.Drawing.Size(137, 17);
            this.checkBoxEncryptionKeyChange.TabIndex = 17;
            this.checkBoxEncryptionKeyChange.Text = "Encryption Key Change";
            this.checkBoxEncryptionKeyChange.UseVisualStyleBackColor = true;
            // 
            // checkBoxExtendedEncryptionKeyChange
            // 
            this.checkBoxExtendedEncryptionKeyChange.AutoSize = true;
            this.checkBoxExtendedEncryptionKeyChange.Location = new System.Drawing.Point(207, 390);
            this.checkBoxExtendedEncryptionKeyChange.Name = "checkBoxExtendedEncryptionKeyChange";
            this.checkBoxExtendedEncryptionKeyChange.Size = new System.Drawing.Size(185, 17);
            this.checkBoxExtendedEncryptionKeyChange.TabIndex = 16;
            this.checkBoxExtendedEncryptionKeyChange.Text = "Extended Encryption Key Change";
            this.checkBoxExtendedEncryptionKeyChange.UseVisualStyleBackColor = true;
            // 
            // buttonSplitSelect
            // 
            this.buttonSplitSelect.Location = new System.Drawing.Point(86, 504);
            this.buttonSplitSelect.Name = "buttonSplitSelect";
            this.buttonSplitSelect.Size = new System.Drawing.Size(142, 27);
            this.buttonSplitSelect.TabIndex = 18;
            this.buttonSplitSelect.Text = "Split select";
            this.buttonSplitSelect.UseVisualStyleBackColor = true;
            this.buttonSplitSelect.Click += new System.EventHandler(this.buttonSplitSelect_Click);
            // 
            // labelInceputMesaj
            // 
            this.labelInceputMesaj.AutoSize = true;
            this.labelInceputMesaj.Location = new System.Drawing.Point(173, 455);
            this.labelInceputMesaj.Name = "labelInceputMesaj";
            this.labelInceputMesaj.Size = new System.Drawing.Size(100, 13);
            this.labelInceputMesaj.TabIndex = 19;
            this.labelInceputMesaj.Text = "Inceputul mesajului:";
            // 
            // labelSfarsitulMesajului
            // 
            this.labelSfarsitulMesajului.AutoSize = true;
            this.labelSfarsitulMesajului.Location = new System.Drawing.Point(177, 481);
            this.labelSfarsitulMesajului.Name = "labelSfarsitulMesajului";
            this.labelSfarsitulMesajului.Size = new System.Drawing.Size(96, 13);
            this.labelSfarsitulMesajului.TabIndex = 20;
            this.labelSfarsitulMesajului.Text = "Sfarsitul  mesajului:";
            // 
            // textBoxInceputulMesajului
            // 
            this.textBoxInceputulMesajului.Location = new System.Drawing.Point(279, 452);
            this.textBoxInceputulMesajului.Name = "textBoxInceputulMesajului";
            this.textBoxInceputulMesajului.Size = new System.Drawing.Size(100, 20);
            this.textBoxInceputulMesajului.TabIndex = 21;
            this.textBoxInceputulMesajului.TextChanged += new System.EventHandler(this.textBoxInceputulMesajului_TextChanged);
            // 
            // textBoxSfarsitulMesajului
            // 
            this.textBoxSfarsitulMesajului.Location = new System.Drawing.Point(279, 478);
            this.textBoxSfarsitulMesajului.Name = "textBoxSfarsitulMesajului";
            this.textBoxSfarsitulMesajului.Size = new System.Drawing.Size(100, 20);
            this.textBoxSfarsitulMesajului.TabIndex = 22;
            this.textBoxSfarsitulMesajului.TextChanged += new System.EventHandler(this.textBoxSfarsitulMesajului_TextChanged);
            // 
            // labelSariPeste
            // 
            this.labelSariPeste.AutoSize = true;
            this.labelSariPeste.Location = new System.Drawing.Point(403, 455);
            this.labelSariPeste.Name = "labelSariPeste";
            this.labelSariPeste.Size = new System.Drawing.Size(93, 13);
            this.labelSariPeste.TabIndex = 23;
            this.labelSariPeste.Text = "Sari peste primele:";
            // 
            // textBoxSariPestePrimele
            // 
            this.textBoxSariPestePrimele.Location = new System.Drawing.Point(502, 452);
            this.textBoxSariPestePrimele.Name = "textBoxSariPestePrimele";
            this.textBoxSariPestePrimele.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxSariPestePrimele.Size = new System.Drawing.Size(43, 20);
            this.textBoxSariPestePrimele.TabIndex = 24;
            this.textBoxSariPestePrimele.Text = "0";
            this.textBoxSariPestePrimele.TextChanged += new System.EventHandler(this.textBoxSariPestePrimele_TextChanged);
            // 
            // labelCaractere
            // 
            this.labelCaractere.AutoSize = true;
            this.labelCaractere.Location = new System.Drawing.Point(551, 455);
            this.labelCaractere.Name = "labelCaractere";
            this.labelCaractere.Size = new System.Drawing.Size(52, 13);
            this.labelCaractere.TabIndex = 25;
            this.labelCaractere.Text = "caractere";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 564);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonArataLog);
            this.tabPage1.Controls.Add(this.textBoxArataLog);
            this.tabPage1.Controls.Add(this.labelInceputMesaj);
            this.tabPage1.Controls.Add(this.labelCaractere);
            this.tabPage1.Controls.Add(this.buttonOpenFile);
            this.tabPage1.Controls.Add(this.textBoxSariPestePrimele);
            this.tabPage1.Controls.Add(this.labelSfarsitulMesajului);
            this.tabPage1.Controls.Add(this.labelSariPeste);
            this.tabPage1.Controls.Add(this.textBoxInceputulMesajului);
            this.tabPage1.Controls.Add(this.textBoxSfarsitulMesajului);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setari si Incarcare";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxMessageIn);
            this.tabPage2.Controls.Add(this.buttonSplitSelect);
            this.tabPage2.Controls.Add(this.textBoxMessageIn);
            this.tabPage2.Controls.Add(this.checkBoxEncryptionKeyChange);
            this.tabPage2.Controls.Add(this.checkBoxConfigurationIDNumber);
            this.tabPage2.Controls.Add(this.checkBoxExtendedEncryptionKeyChange);
            this.tabPage2.Controls.Add(this.checkBoxTerminalCommands);
            this.tabPage2.Controls.Add(this.checkBoxDateAndTime);
            this.tabPage2.Controls.Add(this.labelSplit);
            this.tabPage2.Controls.Add(this.checkBoxInteractiveTransactionResponse);
            this.tabPage2.Controls.Add(this.checkBoxScreenKeyboard);
            this.tabPage2.Controls.Add(this.checkBoxDispencerCurrencyCassetteMapp);
            this.tabPage2.Controls.Add(this.checkBoxFIT);
            this.tabPage2.Controls.Add(this.checkBoxXMLConfigurationDownload);
            this.tabPage2.Controls.Add(this.checkBoxConfigurationParameters);
            this.tabPage2.Controls.Add(this.checkBoxMACFieldSelection);
            this.tabPage2.Controls.Add(this.checkBoxStateTables);
            this.tabPage2.Controls.Add(this.checkBox1EnhancedConfigurationParameters);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Analiza";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxArataLog
            // 
            this.textBoxArataLog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxArataLog.Location = new System.Drawing.Point(9, 44);
            this.textBoxArataLog.Multiline = true;
            this.textBoxArataLog.Name = "textBoxArataLog";
            this.textBoxArataLog.ReadOnly = true;
            this.textBoxArataLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxArataLog.Size = new System.Drawing.Size(770, 400);
            this.textBoxArataLog.TabIndex = 26;
            // 
            // buttonArataLog
            // 
            this.buttonArataLog.Location = new System.Drawing.Point(9, 15);
            this.buttonArataLog.Name = "buttonArataLog";
            this.buttonArataLog.Size = new System.Drawing.Size(147, 23);
            this.buttonArataLog.TabIndex = 27;
            this.buttonArataLog.Text = "Arata MessageIn.log";
            this.buttonArataLog.UseVisualStyleBackColor = true;
            this.buttonArataLog.Click += new System.EventHandler(this.buttonArataLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Analizator NDC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogMessageIn;
        private System.Windows.Forms.ListBox listBoxMessageIn;
        private System.Windows.Forms.TextBox textBoxMessageIn;
        private System.Windows.Forms.CheckBox checkBoxTerminalCommands;
        private System.Windows.Forms.Label labelSplit;
        private System.Windows.Forms.CheckBox checkBoxScreenKeyboard;
        private System.Windows.Forms.CheckBox checkBoxConfigurationIDNumber;
        private System.Windows.Forms.CheckBox checkBoxFIT;
        private System.Windows.Forms.CheckBox checkBoxConfigurationParameters;
        private System.Windows.Forms.CheckBox checkBoxStateTables;
        private System.Windows.Forms.CheckBox checkBoxDateAndTime;
        private System.Windows.Forms.CheckBox checkBoxInteractiveTransactionResponse;
        private System.Windows.Forms.CheckBox checkBoxDispencerCurrencyCassetteMapp;
        private System.Windows.Forms.CheckBox checkBoxXMLConfigurationDownload;
        private System.Windows.Forms.CheckBox checkBoxMACFieldSelection;
        private System.Windows.Forms.CheckBox checkBox1EnhancedConfigurationParameters;
        private System.Windows.Forms.CheckBox checkBoxEncryptionKeyChange;
        private System.Windows.Forms.CheckBox checkBoxExtendedEncryptionKeyChange;
        private System.Windows.Forms.Button buttonSplitSelect;
        private System.Windows.Forms.Label labelInceputMesaj;
        private System.Windows.Forms.Label labelSfarsitulMesajului;
        private System.Windows.Forms.TextBox textBoxInceputulMesajului;
        private System.Windows.Forms.TextBox textBoxSfarsitulMesajului;
        private System.Windows.Forms.Label labelSariPeste;
        private System.Windows.Forms.TextBox textBoxSariPestePrimele;
        private System.Windows.Forms.Label labelCaractere;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonArataLog;
        private System.Windows.Forms.TextBox textBoxArataLog;
    }
}

