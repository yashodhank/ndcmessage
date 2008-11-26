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
            this.buttonArataLog = new System.Windows.Forms.Button();
            this.textBoxArataLog = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxTransactionReplyCommand = new System.Windows.Forms.CheckBox();
            this.checkBoxHostToExitMessages = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelViewStateType = new System.Windows.Forms.Label();
            this.comboBoxViewStateTabel = new System.Windows.Forms.ComboBox();
            this.descriptionLabel8 = new System.Windows.Forms.Label();
            this.descriptionLabel7 = new System.Windows.Forms.Label();
            this.descriptionLabel6 = new System.Windows.Forms.Label();
            this.descriptionLabel5 = new System.Windows.Forms.Label();
            this.descriptionLabel4 = new System.Windows.Forms.Label();
            this.labelDescriptionLabel3 = new System.Windows.Forms.Label();
            this.labelDescriptionLabel2 = new System.Windows.Forms.Label();
            this.labelDescriptionLabel1 = new System.Windows.Forms.Label();
            this.labelDescriptionStateType = new System.Windows.Forms.Label();
            this.textBoxMessType = new System.Windows.Forms.TextBox();
            this.labelMessType = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxStateTabels = new System.Windows.Forms.ListBox();
            this.buttonOpenStateTabels = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 454);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(144, 23);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Analyse MessageIn.log";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // openFileDialogMessageIn
            // 
            this.openFileDialogMessageIn.Filter = "LOG (*.log)|*.log|TextDataBase(*.tdb)|*.tdb|Analyse(*.anl)|*.anl";
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
            this.labelInceputMesaj.Size = new System.Drawing.Size(82, 13);
            this.labelInceputMesaj.TabIndex = 19;
            this.labelInceputMesaj.Text = "Message begin:";
            // 
            // labelSfarsitulMesajului
            // 
            this.labelSfarsitulMesajului.AutoSize = true;
            this.labelSfarsitulMesajului.Location = new System.Drawing.Point(177, 481);
            this.labelSfarsitulMesajului.Name = "labelSfarsitulMesajului";
            this.labelSfarsitulMesajului.Size = new System.Drawing.Size(74, 13);
            this.labelSfarsitulMesajului.TabIndex = 20;
            this.labelSfarsitulMesajului.Text = "Message end:";
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
            this.labelSariPeste.Location = new System.Drawing.Point(387, 455);
            this.labelSariPeste.Name = "labelSariPeste";
            this.labelSariPeste.Size = new System.Drawing.Size(109, 13);
            this.labelSariPeste.TabIndex = 23;
            this.labelSariPeste.Text = "Len header message:";
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
            this.labelCaractere.Size = new System.Drawing.Size(57, 13);
            this.labelCaractere.TabIndex = 25;
            this.labelCaractere.Text = "characters";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
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
            this.tabPage1.Text = "Load and Settings MessageIn.log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonArataLog
            // 
            this.buttonArataLog.Location = new System.Drawing.Point(9, 15);
            this.buttonArataLog.Name = "buttonArataLog";
            this.buttonArataLog.Size = new System.Drawing.Size(147, 23);
            this.buttonArataLog.TabIndex = 27;
            this.buttonArataLog.Text = "Preview MessageIn.log";
            this.buttonArataLog.UseVisualStyleBackColor = true;
            this.buttonArataLog.Click += new System.EventHandler(this.buttonArataLog_Click);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxTransactionReplyCommand);
            this.tabPage2.Controls.Add(this.checkBoxHostToExitMessages);
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
            // checkBoxTransactionReplyCommand
            // 
            this.checkBoxTransactionReplyCommand.AutoSize = true;
            this.checkBoxTransactionReplyCommand.Location = new System.Drawing.Point(207, 436);
            this.checkBoxTransactionReplyCommand.Name = "checkBoxTransactionReplyCommand";
            this.checkBoxTransactionReplyCommand.Size = new System.Drawing.Size(162, 17);
            this.checkBoxTransactionReplyCommand.TabIndex = 20;
            this.checkBoxTransactionReplyCommand.Text = "Transaction Reply Command";
            this.checkBoxTransactionReplyCommand.UseVisualStyleBackColor = true;
            // 
            // checkBoxHostToExitMessages
            // 
            this.checkBoxHostToExitMessages.AutoSize = true;
            this.checkBoxHostToExitMessages.Location = new System.Drawing.Point(207, 413);
            this.checkBoxHostToExitMessages.Name = "checkBoxHostToExitMessages";
            this.checkBoxHostToExitMessages.Size = new System.Drawing.Size(131, 17);
            this.checkBoxHostToExitMessages.TabIndex = 19;
            this.checkBoxHostToExitMessages.Text = "Host to Exit Messages";
            this.checkBoxHostToExitMessages.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(785, 538);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Screens";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.labelViewStateType);
            this.tabPage4.Controls.Add(this.comboBoxViewStateTabel);
            this.tabPage4.Controls.Add(this.descriptionLabel8);
            this.tabPage4.Controls.Add(this.descriptionLabel7);
            this.tabPage4.Controls.Add(this.descriptionLabel6);
            this.tabPage4.Controls.Add(this.descriptionLabel5);
            this.tabPage4.Controls.Add(this.descriptionLabel4);
            this.tabPage4.Controls.Add(this.labelDescriptionLabel3);
            this.tabPage4.Controls.Add(this.labelDescriptionLabel2);
            this.tabPage4.Controls.Add(this.labelDescriptionLabel1);
            this.tabPage4.Controls.Add(this.labelDescriptionStateType);
            this.tabPage4.Controls.Add(this.textBoxMessType);
            this.tabPage4.Controls.Add(this.labelMessType);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.textBox7);
            this.tabPage4.Controls.Add(this.textBox8);
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Controls.Add(this.textBox5);
            this.tabPage4.Controls.Add(this.textBox6);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.listBoxStateTabels);
            this.tabPage4.Controls.Add(this.buttonOpenStateTabels);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(785, 538);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "State Tabels";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // labelViewStateType
            // 
            this.labelViewStateType.AutoSize = true;
            this.labelViewStateType.Location = new System.Drawing.Point(58, 60);
            this.labelViewStateType.Name = "labelViewStateType";
            this.labelViewStateType.Size = new System.Drawing.Size(82, 13);
            this.labelViewStateType.TabIndex = 30;
            this.labelViewStateType.Text = "View state type:";
            // 
            // comboBoxViewStateTabel
            // 
            this.comboBoxViewStateTabel.FormattingEnabled = true;
            this.comboBoxViewStateTabel.Items.AddRange(new object[] {
            "ALL",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "R",
            "S",
            "T",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "b",
            "d",
            "e",
            "g",
            "f",
            "k",
            "m",
            "w",
            "-",
            "&",
            ",",
            ".",
            ";",
            "?",
            "_",
            "+",
            ">",
            "/"});
            this.comboBoxViewStateTabel.Location = new System.Drawing.Point(149, 57);
            this.comboBoxViewStateTabel.Name = "comboBoxViewStateTabel";
            this.comboBoxViewStateTabel.Size = new System.Drawing.Size(64, 21);
            this.comboBoxViewStateTabel.TabIndex = 29;
            this.comboBoxViewStateTabel.SelectedIndexChanged += new System.EventHandler(this.comboBoxViewStateTabel_SelectedIndexChanged);
            // 
            // descriptionLabel8
            // 
            this.descriptionLabel8.AutoSize = true;
            this.descriptionLabel8.Location = new System.Drawing.Point(368, 481);
            this.descriptionLabel8.Name = "descriptionLabel8";
            this.descriptionLabel8.Size = new System.Drawing.Size(89, 13);
            this.descriptionLabel8.TabIndex = 28;
            this.descriptionLabel8.Text = "description label4";
            this.descriptionLabel8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // descriptionLabel7
            // 
            this.descriptionLabel7.AutoSize = true;
            this.descriptionLabel7.Location = new System.Drawing.Point(368, 433);
            this.descriptionLabel7.Name = "descriptionLabel7";
            this.descriptionLabel7.Size = new System.Drawing.Size(89, 13);
            this.descriptionLabel7.TabIndex = 27;
            this.descriptionLabel7.Text = "description label4";
            this.descriptionLabel7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // descriptionLabel6
            // 
            this.descriptionLabel6.AutoSize = true;
            this.descriptionLabel6.Location = new System.Drawing.Point(368, 387);
            this.descriptionLabel6.Name = "descriptionLabel6";
            this.descriptionLabel6.Size = new System.Drawing.Size(89, 13);
            this.descriptionLabel6.TabIndex = 26;
            this.descriptionLabel6.Text = "description label4";
            this.descriptionLabel6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // descriptionLabel5
            // 
            this.descriptionLabel5.AutoSize = true;
            this.descriptionLabel5.Location = new System.Drawing.Point(368, 343);
            this.descriptionLabel5.Name = "descriptionLabel5";
            this.descriptionLabel5.Size = new System.Drawing.Size(89, 13);
            this.descriptionLabel5.TabIndex = 25;
            this.descriptionLabel5.Text = "description label4";
            this.descriptionLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // descriptionLabel4
            // 
            this.descriptionLabel4.AutoSize = true;
            this.descriptionLabel4.Location = new System.Drawing.Point(368, 291);
            this.descriptionLabel4.Name = "descriptionLabel4";
            this.descriptionLabel4.Size = new System.Drawing.Size(89, 13);
            this.descriptionLabel4.TabIndex = 24;
            this.descriptionLabel4.Text = "description label4";
            this.descriptionLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDescriptionLabel3
            // 
            this.labelDescriptionLabel3.AutoSize = true;
            this.labelDescriptionLabel3.Location = new System.Drawing.Point(368, 234);
            this.labelDescriptionLabel3.Name = "labelDescriptionLabel3";
            this.labelDescriptionLabel3.Size = new System.Drawing.Size(89, 13);
            this.labelDescriptionLabel3.TabIndex = 23;
            this.labelDescriptionLabel3.Text = "description label1";
            this.labelDescriptionLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDescriptionLabel2
            // 
            this.labelDescriptionLabel2.AutoSize = true;
            this.labelDescriptionLabel2.Location = new System.Drawing.Point(368, 180);
            this.labelDescriptionLabel2.Name = "labelDescriptionLabel2";
            this.labelDescriptionLabel2.Size = new System.Drawing.Size(89, 13);
            this.labelDescriptionLabel2.TabIndex = 22;
            this.labelDescriptionLabel2.Text = "description label1";
            this.labelDescriptionLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDescriptionLabel1
            // 
            this.labelDescriptionLabel1.AutoSize = true;
            this.labelDescriptionLabel1.Location = new System.Drawing.Point(368, 122);
            this.labelDescriptionLabel1.Name = "labelDescriptionLabel1";
            this.labelDescriptionLabel1.Size = new System.Drawing.Size(89, 13);
            this.labelDescriptionLabel1.TabIndex = 21;
            this.labelDescriptionLabel1.Text = "description label1";
            this.labelDescriptionLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDescriptionStateType
            // 
            this.labelDescriptionStateType.AutoSize = true;
            this.labelDescriptionStateType.Location = new System.Drawing.Point(368, 65);
            this.labelDescriptionStateType.Name = "labelDescriptionStateType";
            this.labelDescriptionStateType.Size = new System.Drawing.Size(107, 13);
            this.labelDescriptionStateType.TabIndex = 20;
            this.labelDescriptionStateType.Text = "description state type";
            this.labelDescriptionStateType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxMessType
            // 
            this.textBoxMessType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMessType.Location = new System.Drawing.Point(371, 42);
            this.textBoxMessType.Name = "textBoxMessType";
            this.textBoxMessType.ReadOnly = true;
            this.textBoxMessType.Size = new System.Drawing.Size(35, 20);
            this.textBoxMessType.TabIndex = 19;
            // 
            // labelMessType
            // 
            this.labelMessType.AutoSize = true;
            this.labelMessType.Location = new System.Drawing.Point(307, 45);
            this.labelMessType.Name = "labelMessType";
            this.labelMessType.Size = new System.Drawing.Size(58, 13);
            this.labelMessType.TabIndex = 18;
            this.labelMessType.Text = "State type:";
            this.labelMessType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "label7";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox7.Location = new System.Drawing.Point(371, 410);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(35, 20);
            this.textBox7.TabIndex = 15;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox8.Location = new System.Drawing.Point(371, 458);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(35, 20);
            this.textBox8.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox4.Location = new System.Drawing.Point(371, 268);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(35, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox5.Location = new System.Drawing.Point(371, 320);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(35, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox6.Location = new System.Drawing.Point(371, 364);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(35, 20);
            this.textBox6.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox3.Location = new System.Drawing.Point(371, 211);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(35, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.Location = new System.Drawing.Point(371, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(35, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(371, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(35, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 102);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // listBoxStateTabels
            // 
            this.listBoxStateTabels.FormattingEnabled = true;
            this.listBoxStateTabels.HorizontalScrollbar = true;
            this.listBoxStateTabels.Location = new System.Drawing.Point(6, 84);
            this.listBoxStateTabels.Name = "listBoxStateTabels";
            this.listBoxStateTabels.Size = new System.Drawing.Size(207, 446);
            this.listBoxStateTabels.Sorted = true;
            this.listBoxStateTabels.TabIndex = 1;
            this.listBoxStateTabels.SelectedIndexChanged += new System.EventHandler(this.listBoxStateTabels_SelectedIndexChanged);
            // 
            // buttonOpenStateTabels
            // 
            this.buttonOpenStateTabels.Location = new System.Drawing.Point(4, 7);
            this.buttonOpenStateTabels.Name = "buttonOpenStateTabels";
            this.buttonOpenStateTabels.Size = new System.Drawing.Size(161, 28);
            this.buttonOpenStateTabels.TabIndex = 0;
            this.buttonOpenStateTabels.Text = "Deschide State Tabels.tdb";
            this.buttonOpenStateTabels.UseVisualStyleBackColor = true;
            this.buttonOpenStateTabels.Click += new System.EventHandler(this.buttonOpenStateTabels_Click);
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
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkBoxHostToExitMessages;
        private System.Windows.Forms.CheckBox checkBoxTransactionReplyCommand;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonOpenStateTabels;
        private System.Windows.Forms.ListBox listBoxStateTabels;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxMessType;
        private System.Windows.Forms.Label labelMessType;
        private System.Windows.Forms.Label labelDescriptionLabel1;
        private System.Windows.Forms.Label labelDescriptionStateType;
        private System.Windows.Forms.Label descriptionLabel4;
        private System.Windows.Forms.Label labelDescriptionLabel3;
        private System.Windows.Forms.Label labelDescriptionLabel2;
        private System.Windows.Forms.Label descriptionLabel6;
        private System.Windows.Forms.Label descriptionLabel5;
        private System.Windows.Forms.Label descriptionLabel8;
        private System.Windows.Forms.Label descriptionLabel7;
        private System.Windows.Forms.ComboBox comboBoxViewStateTabel;
        private System.Windows.Forms.Label labelViewStateType;
    }
}

