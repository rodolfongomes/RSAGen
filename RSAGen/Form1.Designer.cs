namespace RSAtools
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonNewRSA = new System.Windows.Forms.Button();
            this.buttonSign = new System.Windows.Forms.Button();
            this.buttonSignCheck = new System.Windows.Forms.Button();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.textBoxPrivateKey = new System.Windows.Forms.TextBox();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSavePubKey = new System.Windows.Forms.Button();
            this.buttonSavePriKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonOpenPrivateForSign = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSignedForSign = new System.Windows.Forms.TextBox();
            this.textBoxTextForSign = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrivateKeyForSign = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonOpenPublicKeyForSigncheck = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSignedTextForSignCheck = new System.Windows.Forms.TextBox();
            this.labelMsgForSignCheck = new System.Windows.Forms.Label();
            this.textBoxTextForSignCheck = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPublicKeyForSignCheck = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonOpenPublicKeyForEncode = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEncodeForEncode = new System.Windows.Forms.TextBox();
            this.textBoxTextForEncode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPublicKeyForEncode = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonOpenPrivateKeyForDecode = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTextForDecode = new System.Windows.Forms.TextBox();
            this.textBoxEncodeTextForDecode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxPrivateKeyForDecode = new System.Windows.Forms.TextBox();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNewRSA
            // 
            this.buttonNewRSA.Location = new System.Drawing.Point(27, 19);
            this.buttonNewRSA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNewRSA.Name = "buttonNewRSA";
            this.buttonNewRSA.Size = new System.Drawing.Size(122, 54);
            this.buttonNewRSA.TabIndex = 0;
            this.buttonNewRSA.Text = "New RSA";
            this.buttonNewRSA.UseVisualStyleBackColor = true;
            this.buttonNewRSA.Click += new System.EventHandler(this.buttonNewRSA_Click);
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(353, 180);
            this.buttonSign.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(122, 54);
            this.buttonSign.TabIndex = 1;
            this.buttonSign.Text = "Sign";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // buttonSignCheck
            // 
            this.buttonSignCheck.Location = new System.Drawing.Point(353, 231);
            this.buttonSignCheck.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSignCheck.Name = "buttonSignCheck";
            this.buttonSignCheck.Size = new System.Drawing.Size(122, 54);
            this.buttonSignCheck.TabIndex = 2;
            this.buttonSignCheck.Text = "Sign";
            this.buttonSignCheck.UseVisualStyleBackColor = true;
            this.buttonSignCheck.Click += new System.EventHandler(this.buttonSignCheck_Click);
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(353, 231);
            this.buttonEncode.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(122, 54);
            this.buttonEncode.TabIndex = 3;
            this.buttonEncode.Text = "Encode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // textBoxPrivateKey
            // 
            this.textBoxPrivateKey.Location = new System.Drawing.Point(27, 108);
            this.textBoxPrivateKey.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrivateKey.Multiline = true;
            this.textBoxPrivateKey.Name = "textBoxPrivateKey";
            this.textBoxPrivateKey.Size = new System.Drawing.Size(304, 273);
            this.textBoxPrivateKey.TabIndex = 5;
            // 
            // textBoxPublicKey
            // 
            this.textBoxPublicKey.Location = new System.Drawing.Point(353, 108);
            this.textBoxPublicKey.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPublicKey.Multiline = true;
            this.textBoxPublicKey.Name = "textBoxPublicKey";
            this.textBoxPublicKey.Size = new System.Drawing.Size(304, 273);
            this.textBoxPublicKey.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 454);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSavePubKey);
            this.tabPage1.Controls.Add(this.buttonSavePriKey);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxPrivateKey);
            this.tabPage1.Controls.Add(this.textBoxPublicKey);
            this.tabPage1.Controls.Add(this.buttonNewRSA);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(714, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RSA ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSavePubKey
            // 
            this.buttonSavePubKey.Location = new System.Drawing.Point(353, 386);
            this.buttonSavePubKey.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSavePubKey.Name = "buttonSavePubKey";
            this.buttonSavePubKey.Size = new System.Drawing.Size(303, 31);
            this.buttonSavePubKey.TabIndex = 10;
            this.buttonSavePubKey.Text = "Save Public Key";
            this.buttonSavePubKey.UseVisualStyleBackColor = true;
            this.buttonSavePubKey.Click += new System.EventHandler(this.buttonSavePubKey_Click);
            // 
            // buttonSavePriKey
            // 
            this.buttonSavePriKey.Location = new System.Drawing.Point(27, 386);
            this.buttonSavePriKey.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSavePriKey.Name = "buttonSavePriKey";
            this.buttonSavePriKey.Size = new System.Drawing.Size(303, 31);
            this.buttonSavePriKey.TabIndex = 9;
            this.buttonSavePriKey.Text = "Save Private Key";
            this.buttonSavePriKey.UseVisualStyleBackColor = true;
            this.buttonSavePriKey.Click += new System.EventHandler(this.buttonSavePriKey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Public Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Private Key";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonOpenPrivateForSign);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxSignedForSign);
            this.tabPage2.Controls.Add(this.textBoxTextForSign);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBoxPrivateKeyForSign);
            this.tabPage2.Controls.Add(this.buttonSign);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(714, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonOpenPrivateForSign
            // 
            this.buttonOpenPrivateForSign.Location = new System.Drawing.Point(67, 22);
            this.buttonOpenPrivateForSign.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenPrivateForSign.Name = "buttonOpenPrivateForSign";
            this.buttonOpenPrivateForSign.Size = new System.Drawing.Size(102, 28);
            this.buttonOpenPrivateForSign.TabIndex = 13;
            this.buttonOpenPrivateForSign.Text = "Open Private";
            this.buttonOpenPrivateForSign.UseVisualStyleBackColor = true;
            this.buttonOpenPrivateForSign.Click += new System.EventHandler(this.buttonOpenPrivateForSign_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Signed";
            // 
            // textBoxSignedForSign
            // 
            this.textBoxSignedForSign.Location = new System.Drawing.Point(353, 280);
            this.textBoxSignedForSign.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSignedForSign.Multiline = true;
            this.textBoxSignedForSign.Name = "textBoxSignedForSign";
            this.textBoxSignedForSign.Size = new System.Drawing.Size(304, 92);
            this.textBoxSignedForSign.TabIndex = 11;
            // 
            // textBoxTextForSign
            // 
            this.textBoxTextForSign.Location = new System.Drawing.Point(353, 72);
            this.textBoxTextForSign.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTextForSign.Multiline = true;
            this.textBoxTextForSign.Name = "textBoxTextForSign";
            this.textBoxTextForSign.Size = new System.Drawing.Size(304, 92);
            this.textBoxTextForSign.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Text For Sign";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // textBoxPrivateKeyForSign
            // 
            this.textBoxPrivateKeyForSign.Location = new System.Drawing.Point(27, 72);
            this.textBoxPrivateKeyForSign.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrivateKeyForSign.Multiline = true;
            this.textBoxPrivateKeyForSign.Name = "textBoxPrivateKeyForSign";
            this.textBoxPrivateKeyForSign.Size = new System.Drawing.Size(304, 301);
            this.textBoxPrivateKeyForSign.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonOpenPublicKeyForSigncheck);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.textBoxSignedTextForSignCheck);
            this.tabPage3.Controls.Add(this.labelMsgForSignCheck);
            this.tabPage3.Controls.Add(this.textBoxTextForSignCheck);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.textBoxPublicKeyForSignCheck);
            this.tabPage3.Controls.Add(this.buttonSignCheck);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(714, 428);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonOpenPublicKeyForSigncheck
            // 
            this.buttonOpenPublicKeyForSigncheck.Location = new System.Drawing.Point(106, 21);
            this.buttonOpenPublicKeyForSigncheck.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenPublicKeyForSigncheck.Name = "buttonOpenPublicKeyForSigncheck";
            this.buttonOpenPublicKeyForSigncheck.Size = new System.Drawing.Size(102, 28);
            this.buttonOpenPublicKeyForSigncheck.TabIndex = 16;
            this.buttonOpenPublicKeyForSigncheck.Text = "Open Public";
            this.buttonOpenPublicKeyForSigncheck.UseVisualStyleBackColor = true;
            this.buttonOpenPublicKeyForSigncheck.Click += new System.EventHandler(this.buttonOpenPublicKeyForSigncheck_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Assinatura";
            // 
            // textBoxSignedTextForSignCheck
            // 
            this.textBoxSignedTextForSignCheck.Location = new System.Drawing.Point(353, 72);
            this.textBoxSignedTextForSignCheck.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSignedTextForSignCheck.Multiline = true;
            this.textBoxSignedTextForSignCheck.Name = "textBoxSignedTextForSignCheck";
            this.textBoxSignedTextForSignCheck.Size = new System.Drawing.Size(304, 92);
            this.textBoxSignedTextForSignCheck.TabIndex = 14;
            // 
            // labelMsgForSignCheck
            // 
            this.labelMsgForSignCheck.AutoSize = true;
            this.labelMsgForSignCheck.Location = new System.Drawing.Point(495, 249);
            this.labelMsgForSignCheck.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMsgForSignCheck.Name = "labelMsgForSignCheck";
            this.labelMsgForSignCheck.Size = new System.Drawing.Size(87, 13);
            this.labelMsgForSignCheck.TabIndex = 13;
            this.labelMsgForSignCheck.Text = "Status do Exame";
            // 
            // textBoxTextForSignCheck
            // 
            this.textBoxTextForSignCheck.Location = new System.Drawing.Point(27, 231);
            this.textBoxTextForSignCheck.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTextForSignCheck.Multiline = true;
            this.textBoxTextForSignCheck.Name = "textBoxTextForSignCheck";
            this.textBoxTextForSignCheck.Size = new System.Drawing.Size(304, 92);
            this.textBoxTextForSignCheck.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Conteúdo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Chave pública";
            // 
            // textBoxPublicKeyForSignCheck
            // 
            this.textBoxPublicKeyForSignCheck.Location = new System.Drawing.Point(27, 72);
            this.textBoxPublicKeyForSignCheck.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPublicKeyForSignCheck.Multiline = true;
            this.textBoxPublicKeyForSignCheck.Name = "textBoxPublicKeyForSignCheck";
            this.textBoxPublicKeyForSignCheck.Size = new System.Drawing.Size(304, 92);
            this.textBoxPublicKeyForSignCheck.TabIndex = 9;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonOpenPublicKeyForEncode);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.textBoxEncodeForEncode);
            this.tabPage4.Controls.Add(this.textBoxTextForEncode);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.textBoxPublicKeyForEncode);
            this.tabPage4.Controls.Add(this.buttonEncode);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(714, 428);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Encode";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonOpenPublicKeyForEncode
            // 
            this.buttonOpenPublicKeyForEncode.Location = new System.Drawing.Point(106, 21);
            this.buttonOpenPublicKeyForEncode.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenPublicKeyForEncode.Name = "buttonOpenPublicKeyForEncode";
            this.buttonOpenPublicKeyForEncode.Size = new System.Drawing.Size(102, 28);
            this.buttonOpenPublicKeyForEncode.TabIndex = 22;
            this.buttonOpenPublicKeyForEncode.Text = "Open Public";
            this.buttonOpenPublicKeyForEncode.UseVisualStyleBackColor = true;
            this.buttonOpenPublicKeyForEncode.Click += new System.EventHandler(this.buttonOpenPublicKeyForEncode_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 26);
            this.label9.TabIndex = 21;
            this.label9.Text = "\r\nString criptografada";
            // 
            // textBoxEncodeForEncode
            // 
            this.textBoxEncodeForEncode.Location = new System.Drawing.Point(353, 72);
            this.textBoxEncodeForEncode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEncodeForEncode.Multiline = true;
            this.textBoxEncodeForEncode.Name = "textBoxEncodeForEncode";
            this.textBoxEncodeForEncode.Size = new System.Drawing.Size(304, 92);
            this.textBoxEncodeForEncode.TabIndex = 20;
            // 
            // textBoxTextForEncode
            // 
            this.textBoxTextForEncode.Location = new System.Drawing.Point(27, 231);
            this.textBoxTextForEncode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTextForEncode.Multiline = true;
            this.textBoxTextForEncode.Name = "textBoxTextForEncode";
            this.textBoxTextForEncode.Size = new System.Drawing.Size(304, 92);
            this.textBoxTextForEncode.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 188);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 26);
            this.label10.TabIndex = 18;
            this.label10.Text = "\r\nConteúdo a ser criptografado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 29);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Chave pública\r\n";
            // 
            // textBoxPublicKeyForEncode
            // 
            this.textBoxPublicKeyForEncode.Location = new System.Drawing.Point(27, 72);
            this.textBoxPublicKeyForEncode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPublicKeyForEncode.Multiline = true;
            this.textBoxPublicKeyForEncode.Name = "textBoxPublicKeyForEncode";
            this.textBoxPublicKeyForEncode.Size = new System.Drawing.Size(304, 92);
            this.textBoxPublicKeyForEncode.TabIndex = 16;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonOpenPrivateKeyForDecode);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.textBoxTextForDecode);
            this.tabPage5.Controls.Add(this.textBoxEncodeTextForDecode);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.textBoxPrivateKeyForDecode);
            this.tabPage5.Controls.Add(this.buttonDecode);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(714, 428);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Decode";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonOpenPrivateKeyForDecode
            // 
            this.buttonOpenPrivateKeyForDecode.Location = new System.Drawing.Point(107, 21);
            this.buttonOpenPrivateKeyForDecode.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenPrivateKeyForDecode.Name = "buttonOpenPrivateKeyForDecode";
            this.buttonOpenPrivateKeyForDecode.Size = new System.Drawing.Size(102, 28);
            this.buttonOpenPrivateKeyForDecode.TabIndex = 20;
            this.buttonOpenPrivateKeyForDecode.Text = "Open Private";
            this.buttonOpenPrivateKeyForDecode.UseVisualStyleBackColor = true;
            this.buttonOpenPrivateKeyForDecode.Click += new System.EventHandler(this.buttonOpenPrivateKeyForDecode_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(353, 251);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Conteúdo descriptografado";
            // 
            // textBoxTextForDecode
            // 
            this.textBoxTextForDecode.Location = new System.Drawing.Point(353, 282);
            this.textBoxTextForDecode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTextForDecode.Multiline = true;
            this.textBoxTextForDecode.Name = "textBoxTextForDecode";
            this.textBoxTextForDecode.Size = new System.Drawing.Size(304, 92);
            this.textBoxTextForDecode.TabIndex = 18;
            // 
            // textBoxEncodeTextForDecode
            // 
            this.textBoxEncodeTextForDecode.Location = new System.Drawing.Point(353, 72);
            this.textBoxEncodeTextForDecode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEncodeTextForDecode.Multiline = true;
            this.textBoxEncodeTextForDecode.Name = "textBoxEncodeTextForDecode";
            this.textBoxEncodeTextForDecode.Size = new System.Drawing.Size(304, 92);
            this.textBoxEncodeTextForDecode.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(353, 29);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Conteúdo a ser descriptografado";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 29);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Chave privada";
            // 
            // textBoxPrivateKeyForDecode
            // 
            this.textBoxPrivateKeyForDecode.Location = new System.Drawing.Point(27, 72);
            this.textBoxPrivateKeyForDecode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrivateKeyForDecode.Multiline = true;
            this.textBoxPrivateKeyForDecode.Name = "textBoxPrivateKeyForDecode";
            this.textBoxPrivateKeyForDecode.Size = new System.Drawing.Size(304, 301);
            this.textBoxPrivateKeyForDecode.TabIndex = 14;
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(353, 181);
            this.buttonDecode.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(122, 54);
            this.buttonDecode.TabIndex = 13;
            this.buttonDecode.Text = "Decode";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 490);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewRSA;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Button buttonSignCheck;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.TextBox textBoxPrivateKey;
        private System.Windows.Forms.TextBox textBoxPublicKey;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSignedForSign;
        private System.Windows.Forms.TextBox textBoxTextForSign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrivateKeyForSign;
        private System.Windows.Forms.Label labelMsgForSignCheck;
        private System.Windows.Forms.TextBox textBoxTextForSignCheck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPublicKeyForSignCheck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSignedTextForSignCheck;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEncodeForEncode;
        private System.Windows.Forms.TextBox textBoxTextForEncode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPublicKeyForEncode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxTextForDecode;
        private System.Windows.Forms.TextBox textBoxEncodeTextForDecode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxPrivateKeyForDecode;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Button buttonSavePubKey;
        private System.Windows.Forms.Button buttonSavePriKey;
        private System.Windows.Forms.Button buttonOpenPrivateForSign;
        private System.Windows.Forms.Button buttonOpenPublicKeyForSigncheck;
        private System.Windows.Forms.Button buttonOpenPublicKeyForEncode;
        private System.Windows.Forms.Button buttonOpenPrivateKeyForDecode;
    }
}

