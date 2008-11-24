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
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 12);
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
            this.listBoxMessageIn.Size = new System.Drawing.Size(92, 212);
            this.listBoxMessageIn.TabIndex = 1;
            this.listBoxMessageIn.SelectedIndexChanged += new System.EventHandler(this.listBoxMessageIn_SelectedIndexChanged);
            // 
            // textBoxMessageIn
            // 
            this.textBoxMessageIn.Location = new System.Drawing.Point(110, 41);
            this.textBoxMessageIn.Multiline = true;
            this.textBoxMessageIn.Name = "textBoxMessageIn";
            this.textBoxMessageIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessageIn.Size = new System.Drawing.Size(670, 212);
            this.textBoxMessageIn.TabIndex = 2;
            // 
            // checkBoxTerminalCommands
            // 
            this.checkBoxTerminalCommands.AutoSize = true;
            this.checkBoxTerminalCommands.Location = new System.Drawing.Point(41, 304);
            this.checkBoxTerminalCommands.Name = "checkBoxTerminalCommands";
            this.checkBoxTerminalCommands.Size = new System.Drawing.Size(121, 17);
            this.checkBoxTerminalCommands.TabIndex = 3;
            this.checkBoxTerminalCommands.Text = "Terminal Commands";
            this.checkBoxTerminalCommands.UseVisualStyleBackColor = true;
            // 
            // labelSplit
            // 
            this.labelSplit.AutoSize = true;
            this.labelSplit.Location = new System.Drawing.Point(162, 268);
            this.labelSplit.Name = "labelSplit";
            this.labelSplit.Size = new System.Drawing.Size(75, 13);
            this.labelSplit.TabIndex = 4;
            this.labelSplit.Text = "Extract exit file";
            // 
            // checkBoxScreenKeyboard
            // 
            this.checkBoxScreenKeyboard.AutoSize = true;
            this.checkBoxScreenKeyboard.Location = new System.Drawing.Point(41, 327);
            this.checkBoxScreenKeyboard.Name = "checkBoxScreenKeyboard";
            this.checkBoxScreenKeyboard.Size = new System.Drawing.Size(110, 17);
            this.checkBoxScreenKeyboard.TabIndex = 5;
            this.checkBoxScreenKeyboard.Text = "Screen/Keyboard";
            this.checkBoxScreenKeyboard.UseVisualStyleBackColor = true;
            // 
            // checkBoxConfigurationIDNumber
            // 
            this.checkBoxConfigurationIDNumber.AutoSize = true;
            this.checkBoxConfigurationIDNumber.Location = new System.Drawing.Point(41, 419);
            this.checkBoxConfigurationIDNumber.Name = "checkBoxConfigurationIDNumber";
            this.checkBoxConfigurationIDNumber.Size = new System.Drawing.Size(142, 17);
            this.checkBoxConfigurationIDNumber.TabIndex = 6;
            this.checkBoxConfigurationIDNumber.Text = "Configuration ID Number";
            this.checkBoxConfigurationIDNumber.UseVisualStyleBackColor = true;
            // 
            // checkBoxFIT
            // 
            this.checkBoxFIT.AutoSize = true;
            this.checkBoxFIT.Location = new System.Drawing.Point(41, 396);
            this.checkBoxFIT.Name = "checkBoxFIT";
            this.checkBoxFIT.Size = new System.Drawing.Size(42, 17);
            this.checkBoxFIT.TabIndex = 7;
            this.checkBoxFIT.Text = "FIT";
            this.checkBoxFIT.UseVisualStyleBackColor = true;
            // 
            // checkBoxConfigurationParameters
            // 
            this.checkBoxConfigurationParameters.AutoSize = true;
            this.checkBoxConfigurationParameters.Location = new System.Drawing.Point(41, 373);
            this.checkBoxConfigurationParameters.Name = "checkBoxConfigurationParameters";
            this.checkBoxConfigurationParameters.Size = new System.Drawing.Size(144, 17);
            this.checkBoxConfigurationParameters.TabIndex = 8;
            this.checkBoxConfigurationParameters.Text = "Configuration Parameters";
            this.checkBoxConfigurationParameters.UseVisualStyleBackColor = true;
            // 
            // checkBoxStateTables
            // 
            this.checkBoxStateTables.AutoSize = true;
            this.checkBoxStateTables.Location = new System.Drawing.Point(41, 350);
            this.checkBoxStateTables.Name = "checkBoxStateTables";
            this.checkBoxStateTables.Size = new System.Drawing.Size(86, 17);
            this.checkBoxStateTables.TabIndex = 9;
            this.checkBoxStateTables.Text = "State Tables";
            this.checkBoxStateTables.UseVisualStyleBackColor = true;
            // 
            // checkBoxDateAndTime
            // 
            this.checkBoxDateAndTime.AutoSize = true;
            this.checkBoxDateAndTime.Location = new System.Drawing.Point(41, 487);
            this.checkBoxDateAndTime.Name = "checkBoxDateAndTime";
            this.checkBoxDateAndTime.Size = new System.Drawing.Size(96, 17);
            this.checkBoxDateAndTime.TabIndex = 15;
            this.checkBoxDateAndTime.Text = "Date and Time";
            this.checkBoxDateAndTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxInteractiveTransactionResponse
            // 
            this.checkBoxInteractiveTransactionResponse.AutoSize = true;
            this.checkBoxInteractiveTransactionResponse.Location = new System.Drawing.Point(242, 350);
            this.checkBoxInteractiveTransactionResponse.Name = "checkBoxInteractiveTransactionResponse";
            this.checkBoxInteractiveTransactionResponse.Size = new System.Drawing.Size(186, 17);
            this.checkBoxInteractiveTransactionResponse.TabIndex = 14;
            this.checkBoxInteractiveTransactionResponse.Text = "Interactive Transaction Response";
            this.checkBoxInteractiveTransactionResponse.UseVisualStyleBackColor = true;
            // 
            // checkBoxDispencerCurrencyCassetteMapp
            // 
            this.checkBoxDispencerCurrencyCassetteMapp.AutoSize = true;
            this.checkBoxDispencerCurrencyCassetteMapp.Location = new System.Drawing.Point(242, 304);
            this.checkBoxDispencerCurrencyCassetteMapp.Name = "checkBoxDispencerCurrencyCassetteMapp";
            this.checkBoxDispencerCurrencyCassetteMapp.Size = new System.Drawing.Size(206, 17);
            this.checkBoxDispencerCurrencyCassetteMapp.TabIndex = 13;
            this.checkBoxDispencerCurrencyCassetteMapp.Text = "Dispenser Currency Cassette Mapping";
            this.checkBoxDispencerCurrencyCassetteMapp.UseVisualStyleBackColor = true;
            // 
            // checkBoxXMLConfigurationDownload
            // 
            this.checkBoxXMLConfigurationDownload.AutoSize = true;
            this.checkBoxXMLConfigurationDownload.Location = new System.Drawing.Point(242, 327);
            this.checkBoxXMLConfigurationDownload.Name = "checkBoxXMLConfigurationDownload";
            this.checkBoxXMLConfigurationDownload.Size = new System.Drawing.Size(164, 17);
            this.checkBoxXMLConfigurationDownload.TabIndex = 12;
            this.checkBoxXMLConfigurationDownload.Text = "XML Configuration Download";
            this.checkBoxXMLConfigurationDownload.UseVisualStyleBackColor = true;
            // 
            // checkBoxMACFieldSelection
            // 
            this.checkBoxMACFieldSelection.AutoSize = true;
            this.checkBoxMACFieldSelection.Location = new System.Drawing.Point(41, 464);
            this.checkBoxMACFieldSelection.Name = "checkBoxMACFieldSelection";
            this.checkBoxMACFieldSelection.Size = new System.Drawing.Size(121, 17);
            this.checkBoxMACFieldSelection.TabIndex = 11;
            this.checkBoxMACFieldSelection.Text = "MAC Field Selection";
            this.checkBoxMACFieldSelection.UseVisualStyleBackColor = true;
            // 
            // checkBox1EnhancedConfigurationParameters
            // 
            this.checkBox1EnhancedConfigurationParameters.AutoSize = true;
            this.checkBox1EnhancedConfigurationParameters.Location = new System.Drawing.Point(41, 441);
            this.checkBox1EnhancedConfigurationParameters.Name = "checkBox1EnhancedConfigurationParameters";
            this.checkBox1EnhancedConfigurationParameters.Size = new System.Drawing.Size(196, 17);
            this.checkBox1EnhancedConfigurationParameters.TabIndex = 10;
            this.checkBox1EnhancedConfigurationParameters.Text = "Enhanced Configuration Parameters";
            this.checkBox1EnhancedConfigurationParameters.UseVisualStyleBackColor = true;
            // 
            // checkBoxEncryptionKeyChange
            // 
            this.checkBoxEncryptionKeyChange.AutoSize = true;
            this.checkBoxEncryptionKeyChange.Location = new System.Drawing.Point(242, 373);
            this.checkBoxEncryptionKeyChange.Name = "checkBoxEncryptionKeyChange";
            this.checkBoxEncryptionKeyChange.Size = new System.Drawing.Size(137, 17);
            this.checkBoxEncryptionKeyChange.TabIndex = 17;
            this.checkBoxEncryptionKeyChange.Text = "Encryption Key Change";
            this.checkBoxEncryptionKeyChange.UseVisualStyleBackColor = true;
            // 
            // checkBoxExtendedEncryptionKeyChange
            // 
            this.checkBoxExtendedEncryptionKeyChange.AutoSize = true;
            this.checkBoxExtendedEncryptionKeyChange.Location = new System.Drawing.Point(242, 396);
            this.checkBoxExtendedEncryptionKeyChange.Name = "checkBoxExtendedEncryptionKeyChange";
            this.checkBoxExtendedEncryptionKeyChange.Size = new System.Drawing.Size(185, 17);
            this.checkBoxExtendedEncryptionKeyChange.TabIndex = 16;
            this.checkBoxExtendedEncryptionKeyChange.Text = "Extended Encryption Key Change";
            this.checkBoxExtendedEncryptionKeyChange.UseVisualStyleBackColor = true;
            // 
            // buttonSplitSelect
            // 
            this.buttonSplitSelect.Location = new System.Drawing.Point(121, 510);
            this.buttonSplitSelect.Name = "buttonSplitSelect";
            this.buttonSplitSelect.Size = new System.Drawing.Size(142, 27);
            this.buttonSplitSelect.TabIndex = 18;
            this.buttonSplitSelect.Text = "Split select";
            this.buttonSplitSelect.UseVisualStyleBackColor = true;
            this.buttonSplitSelect.Click += new System.EventHandler(this.buttonSplitSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.buttonSplitSelect);
            this.Controls.Add(this.checkBoxEncryptionKeyChange);
            this.Controls.Add(this.checkBoxExtendedEncryptionKeyChange);
            this.Controls.Add(this.checkBoxDateAndTime);
            this.Controls.Add(this.checkBoxInteractiveTransactionResponse);
            this.Controls.Add(this.checkBoxDispencerCurrencyCassetteMapp);
            this.Controls.Add(this.checkBoxXMLConfigurationDownload);
            this.Controls.Add(this.checkBoxMACFieldSelection);
            this.Controls.Add(this.checkBox1EnhancedConfigurationParameters);
            this.Controls.Add(this.checkBoxStateTables);
            this.Controls.Add(this.checkBoxConfigurationParameters);
            this.Controls.Add(this.checkBoxFIT);
            this.Controls.Add(this.checkBoxConfigurationIDNumber);
            this.Controls.Add(this.checkBoxScreenKeyboard);
            this.Controls.Add(this.labelSplit);
            this.Controls.Add(this.checkBoxTerminalCommands);
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
    }
}

