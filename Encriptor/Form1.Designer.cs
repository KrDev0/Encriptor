namespace Encriptor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtDecrypt = new System.Windows.Forms.RichTextBox();
            this.txtEncrypt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.encrsa = new System.Windows.Forms.Button();
            this.desrsa = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtEncryptmd5 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.encripmd5 = new System.Windows.Forms.Button();
            this.txtInputmd5 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtDecryptROT13 = new System.Windows.Forms.RichTextBox();
            this.txtEncryptROT13 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.encriprot13 = new System.Windows.Forms.Button();
            this.decriptrot13 = new System.Windows.Forms.Button();
            this.txtInputROT13 = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtOutputbinary = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.encripbinay = new System.Windows.Forms.Button();
            this.txtInputbinay = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtLlave = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDecryptrc4 = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEncryptrc4 = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.encriptrc4 = new System.Windows.Forms.Button();
            this.deciptrc4 = new System.Windows.Forms.Button();
            this.txtInputrc4 = new System.Windows.Forms.RichTextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDecrypt3des = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEncrypt3des = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.encri3des = new System.Windows.Forms.Button();
            this.decript3des = new System.Windows.Forms.Button();
            this.txtInput3des = new System.Windows.Forms.RichTextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCopyPass = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordLength = new System.Windows.Forms.TextBox();
            this.chkSpecical = new System.Windows.Forms.CheckBox();
            this.chkNumeric = new System.Windows.Forms.CheckBox();
            this.chkUpperCase = new System.Windows.Forms.CheckBox();
            this.chkLowerCase = new System.Windows.Forms.CheckBox();
            this.decript = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.decriptbinary = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 503);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtDecrypt);
            this.tabPage1.Controls.Add(this.txtEncrypt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.encrsa);
            this.tabPage1.Controls.Add(this.desrsa);
            this.tabPage1.Controls.Add(this.txtInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RSA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(8, 307);
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(670, 119);
            this.txtDecrypt.TabIndex = 7;
            this.txtDecrypt.Text = "";
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(8, 165);
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(670, 119);
            this.txtEncrypt.TabIndex = 6;
            this.txtEncrypt.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desencriptado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Encriptado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contenido:";
            // 
            // encrsa
            // 
            this.encrsa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encrsa.Location = new System.Drawing.Point(578, 434);
            this.encrsa.Name = "encrsa";
            this.encrsa.Size = new System.Drawing.Size(100, 33);
            this.encrsa.TabIndex = 4;
            this.encrsa.Text = "Encriptar";
            this.encrsa.UseVisualStyleBackColor = true;
            this.encrsa.Click += new System.EventHandler(this.encrsa_Click);
            // 
            // desrsa
            // 
            this.desrsa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desrsa.Location = new System.Drawing.Point(472, 434);
            this.desrsa.Name = "desrsa";
            this.desrsa.Size = new System.Drawing.Size(100, 33);
            this.desrsa.TabIndex = 3;
            this.desrsa.Text = "Desencriptar";
            this.desrsa.UseVisualStyleBackColor = true;
            this.desrsa.Click += new System.EventHandler(this.desrsa_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(8, 23);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(670, 119);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtEncryptmd5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.encripmd5);
            this.tabPage2.Controls.Add(this.txtInputmd5);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(686, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MD5";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtEncryptmd5
            // 
            this.txtEncryptmd5.Location = new System.Drawing.Point(8, 165);
            this.txtEncryptmd5.Name = "txtEncryptmd5";
            this.txtEncryptmd5.Size = new System.Drawing.Size(670, 119);
            this.txtEncryptmd5.TabIndex = 12;
            this.txtEncryptmd5.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Encriptado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contenido:";
            // 
            // encripmd5
            // 
            this.encripmd5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encripmd5.Location = new System.Drawing.Point(578, 434);
            this.encripmd5.Name = "encripmd5";
            this.encripmd5.Size = new System.Drawing.Size(100, 33);
            this.encripmd5.TabIndex = 9;
            this.encripmd5.Text = "Encriptar";
            this.encripmd5.UseVisualStyleBackColor = true;
            this.encripmd5.Click += new System.EventHandler(this.encripmd5_Click);
            // 
            // txtInputmd5
            // 
            this.txtInputmd5.Location = new System.Drawing.Point(8, 23);
            this.txtInputmd5.Name = "txtInputmd5";
            this.txtInputmd5.Size = new System.Drawing.Size(670, 119);
            this.txtInputmd5.TabIndex = 7;
            this.txtInputmd5.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtDecryptROT13);
            this.tabPage3.Controls.Add(this.txtEncryptROT13);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.encriprot13);
            this.tabPage3.Controls.Add(this.decriptrot13);
            this.tabPage3.Controls.Add(this.txtInputROT13);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(686, 473);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ROT13";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtDecryptROT13
            // 
            this.txtDecryptROT13.Location = new System.Drawing.Point(8, 307);
            this.txtDecryptROT13.Name = "txtDecryptROT13";
            this.txtDecryptROT13.Size = new System.Drawing.Size(670, 119);
            this.txtDecryptROT13.TabIndex = 15;
            this.txtDecryptROT13.Text = "";
            // 
            // txtEncryptROT13
            // 
            this.txtEncryptROT13.Location = new System.Drawing.Point(8, 165);
            this.txtEncryptROT13.Name = "txtEncryptROT13";
            this.txtEncryptROT13.Size = new System.Drawing.Size(670, 119);
            this.txtEncryptROT13.TabIndex = 14;
            this.txtEncryptROT13.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Desencriptado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Encriptado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Contenido:";
            // 
            // encriprot13
            // 
            this.encriprot13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encriprot13.Location = new System.Drawing.Point(578, 434);
            this.encriprot13.Name = "encriprot13";
            this.encriprot13.Size = new System.Drawing.Size(100, 33);
            this.encriprot13.TabIndex = 10;
            this.encriprot13.Text = "Encriptar";
            this.encriprot13.UseVisualStyleBackColor = true;
            this.encriprot13.Click += new System.EventHandler(this.encriprot13_Click);
            // 
            // decriptrot13
            // 
            this.decriptrot13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decriptrot13.Location = new System.Drawing.Point(472, 434);
            this.decriptrot13.Name = "decriptrot13";
            this.decriptrot13.Size = new System.Drawing.Size(100, 33);
            this.decriptrot13.TabIndex = 9;
            this.decriptrot13.Text = "Desencriptar";
            this.decriptrot13.UseVisualStyleBackColor = true;
            this.decriptrot13.Click += new System.EventHandler(this.decriptrot13_Click);
            // 
            // txtInputROT13
            // 
            this.txtInputROT13.Location = new System.Drawing.Point(8, 23);
            this.txtInputROT13.Name = "txtInputROT13";
            this.txtInputROT13.Size = new System.Drawing.Size(670, 119);
            this.txtInputROT13.TabIndex = 8;
            this.txtInputROT13.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.decript);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.txtOutputbinary);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.encripbinay);
            this.tabPage4.Controls.Add(this.decriptbinary);
            this.tabPage4.Controls.Add(this.txtInputbinay);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(686, 473);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "BINARIO";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtOutputbinary
            // 
            this.txtOutputbinary.Location = new System.Drawing.Point(8, 165);
            this.txtOutputbinary.Name = "txtOutputbinary";
            this.txtOutputbinary.Size = new System.Drawing.Size(670, 119);
            this.txtOutputbinary.TabIndex = 18;
            this.txtOutputbinary.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Encriptado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Contenido:";
            // 
            // encripbinay
            // 
            this.encripbinay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encripbinay.Location = new System.Drawing.Point(578, 434);
            this.encripbinay.Name = "encripbinay";
            this.encripbinay.Size = new System.Drawing.Size(100, 33);
            this.encripbinay.TabIndex = 15;
            this.encripbinay.Text = "Encriptar";
            this.encripbinay.UseVisualStyleBackColor = true;
            this.encripbinay.Click += new System.EventHandler(this.encripbinay_Click);
            // 
            // txtInputbinay
            // 
            this.txtInputbinay.Location = new System.Drawing.Point(8, 23);
            this.txtInputbinay.Name = "txtInputbinay";
            this.txtInputbinay.Size = new System.Drawing.Size(670, 119);
            this.txtInputbinay.TabIndex = 13;
            this.txtInputbinay.Text = "";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtLlave);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.txtDecryptrc4);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.txtEncryptrc4);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.encriptrc4);
            this.tabPage5.Controls.Add(this.deciptrc4);
            this.tabPage5.Controls.Add(this.txtInputrc4);
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(686, 473);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "RC4";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtLlave
            // 
            this.txtLlave.Location = new System.Drawing.Point(51, 436);
            this.txtLlave.Name = "txtLlave";
            this.txtLlave.Size = new System.Drawing.Size(415, 25);
            this.txtLlave.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 439);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 17);
            this.label15.TabIndex = 29;
            this.label15.Text = "Llave:";
            // 
            // txtDecryptrc4
            // 
            this.txtDecryptrc4.Location = new System.Drawing.Point(8, 307);
            this.txtDecryptrc4.Name = "txtDecryptrc4";
            this.txtDecryptrc4.Size = new System.Drawing.Size(670, 119);
            this.txtDecryptrc4.TabIndex = 28;
            this.txtDecryptrc4.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Desencriptado:";
            // 
            // txtEncryptrc4
            // 
            this.txtEncryptrc4.Location = new System.Drawing.Point(8, 165);
            this.txtEncryptrc4.Name = "txtEncryptrc4";
            this.txtEncryptrc4.Size = new System.Drawing.Size(670, 119);
            this.txtEncryptrc4.TabIndex = 26;
            this.txtEncryptrc4.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Encriptado:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "Contenido:";
            // 
            // encriptrc4
            // 
            this.encriptrc4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encriptrc4.Location = new System.Drawing.Point(578, 434);
            this.encriptrc4.Name = "encriptrc4";
            this.encriptrc4.Size = new System.Drawing.Size(100, 33);
            this.encriptrc4.TabIndex = 23;
            this.encriptrc4.Text = "Encriptar";
            this.encriptrc4.UseVisualStyleBackColor = true;
            this.encriptrc4.Click += new System.EventHandler(this.encriptrc4_Click);
            // 
            // deciptrc4
            // 
            this.deciptrc4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deciptrc4.Location = new System.Drawing.Point(472, 434);
            this.deciptrc4.Name = "deciptrc4";
            this.deciptrc4.Size = new System.Drawing.Size(100, 33);
            this.deciptrc4.TabIndex = 22;
            this.deciptrc4.Text = "Desencriptar";
            this.deciptrc4.UseVisualStyleBackColor = true;
            this.deciptrc4.Click += new System.EventHandler(this.deciptrc4_Click);
            // 
            // txtInputrc4
            // 
            this.txtInputrc4.Location = new System.Drawing.Point(8, 23);
            this.txtInputrc4.Name = "txtInputrc4";
            this.txtInputrc4.Size = new System.Drawing.Size(670, 119);
            this.txtInputrc4.TabIndex = 21;
            this.txtInputrc4.Text = "";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.txtKey);
            this.tabPage6.Controls.Add(this.label16);
            this.tabPage6.Controls.Add(this.txtDecrypt3des);
            this.tabPage6.Controls.Add(this.label17);
            this.tabPage6.Controls.Add(this.txtEncrypt3des);
            this.tabPage6.Controls.Add(this.label18);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Controls.Add(this.encri3des);
            this.tabPage6.Controls.Add(this.decript3des);
            this.tabPage6.Controls.Add(this.txtInput3des);
            this.tabPage6.Location = new System.Drawing.Point(4, 26);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(686, 473);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "3DES";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(51, 436);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(413, 25);
            this.txtKey.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 439);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 17);
            this.label16.TabIndex = 39;
            this.label16.Text = "Llave:";
            // 
            // txtDecrypt3des
            // 
            this.txtDecrypt3des.Location = new System.Drawing.Point(8, 307);
            this.txtDecrypt3des.Name = "txtDecrypt3des";
            this.txtDecrypt3des.Size = new System.Drawing.Size(668, 119);
            this.txtDecrypt3des.TabIndex = 38;
            this.txtDecrypt3des.Text = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 287);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 17);
            this.label17.TabIndex = 37;
            this.label17.Text = "Desencriptado:";
            // 
            // txtEncrypt3des
            // 
            this.txtEncrypt3des.Location = new System.Drawing.Point(8, 165);
            this.txtEncrypt3des.Name = "txtEncrypt3des";
            this.txtEncrypt3des.Size = new System.Drawing.Size(668, 119);
            this.txtEncrypt3des.TabIndex = 36;
            this.txtEncrypt3des.Text = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 145);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 17);
            this.label18.TabIndex = 34;
            this.label18.Text = "Encriptado:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 17);
            this.label19.TabIndex = 35;
            this.label19.Text = "Contenido:";
            // 
            // encri3des
            // 
            this.encri3des.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encri3des.Location = new System.Drawing.Point(578, 434);
            this.encri3des.Name = "encri3des";
            this.encri3des.Size = new System.Drawing.Size(100, 33);
            this.encri3des.TabIndex = 33;
            this.encri3des.Text = "Encriptar";
            this.encri3des.UseVisualStyleBackColor = true;
            this.encri3des.Click += new System.EventHandler(this.encri3des_Click);
            // 
            // decript3des
            // 
            this.decript3des.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decript3des.Location = new System.Drawing.Point(472, 434);
            this.decript3des.Name = "decript3des";
            this.decript3des.Size = new System.Drawing.Size(100, 33);
            this.decript3des.TabIndex = 32;
            this.decript3des.Text = "Desencriptar";
            this.decript3des.UseVisualStyleBackColor = true;
            this.decript3des.Click += new System.EventHandler(this.decript3des_Click);
            // 
            // txtInput3des
            // 
            this.txtInput3des.Location = new System.Drawing.Point(8, 23);
            this.txtInput3des.Name = "txtInput3des";
            this.txtInput3des.Size = new System.Drawing.Size(668, 119);
            this.txtInput3des.TabIndex = 31;
            this.txtInput3des.Text = "";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btnGenerar);
            this.tabPage7.Controls.Add(this.btnClear);
            this.tabPage7.Controls.Add(this.btnCopyPass);
            this.tabPage7.Controls.Add(this.label21);
            this.tabPage7.Controls.Add(this.label20);
            this.tabPage7.Controls.Add(this.txtPassword);
            this.tabPage7.Controls.Add(this.txtPasswordLength);
            this.tabPage7.Controls.Add(this.chkSpecical);
            this.tabPage7.Controls.Add(this.chkNumeric);
            this.tabPage7.Controls.Add(this.chkUpperCase);
            this.tabPage7.Controls.Add(this.chkLowerCase);
            this.tabPage7.Location = new System.Drawing.Point(4, 26);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(686, 473);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "CONTRASEÑA";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(448, 308);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 33);
            this.btnGenerar.TabIndex = 36;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(342, 308);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 33);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCopyPass
            // 
            this.btnCopyPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyPass.Location = new System.Drawing.Point(202, 308);
            this.btnCopyPass.Name = "btnCopyPass";
            this.btnCopyPass.Size = new System.Drawing.Size(134, 33);
            this.btnCopyPass.TabIndex = 34;
            this.btnCopyPass.Text = "Copiar contaseña";
            this.btnCopyPass.UseVisualStyleBackColor = true;
            this.btnCopyPass.Click += new System.EventHandler(this.btnCopyPass_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(33, 214);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(163, 17);
            this.label21.TabIndex = 7;
            this.label21.Text = "Longitud de la contraseña:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(119, 266);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 17);
            this.label20.TabIndex = 6;
            this.label20.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(202, 263);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(346, 25);
            this.txtPassword.TabIndex = 5;
            // 
            // txtPasswordLength
            // 
            this.txtPasswordLength.Location = new System.Drawing.Point(202, 211);
            this.txtPasswordLength.Name = "txtPasswordLength";
            this.txtPasswordLength.Size = new System.Drawing.Size(346, 25);
            this.txtPasswordLength.TabIndex = 4;
            // 
            // chkSpecical
            // 
            this.chkSpecical.AutoSize = true;
            this.chkSpecical.Location = new System.Drawing.Point(36, 154);
            this.chkSpecical.Name = "chkSpecical";
            this.chkSpecical.Size = new System.Drawing.Size(153, 21);
            this.chkSpecical.TabIndex = 3;
            this.chkSpecical.Text = "Caracteres especiales";
            this.chkSpecical.UseVisualStyleBackColor = true;
            // 
            // chkNumeric
            // 
            this.chkNumeric.AutoSize = true;
            this.chkNumeric.Location = new System.Drawing.Point(36, 116);
            this.chkNumeric.Name = "chkNumeric";
            this.chkNumeric.Size = new System.Drawing.Size(81, 21);
            this.chkNumeric.TabIndex = 2;
            this.chkNumeric.Text = "Numeros";
            this.chkNumeric.UseVisualStyleBackColor = true;
            // 
            // chkUpperCase
            // 
            this.chkUpperCase.AutoSize = true;
            this.chkUpperCase.Location = new System.Drawing.Point(36, 79);
            this.chkUpperCase.Name = "chkUpperCase";
            this.chkUpperCase.Size = new System.Drawing.Size(132, 21);
            this.chkUpperCase.TabIndex = 1;
            this.chkUpperCase.Text = "Letras mayusculas";
            this.chkUpperCase.UseVisualStyleBackColor = true;
            // 
            // chkLowerCase
            // 
            this.chkLowerCase.AutoSize = true;
            this.chkLowerCase.Location = new System.Drawing.Point(36, 43);
            this.chkLowerCase.Name = "chkLowerCase";
            this.chkLowerCase.Size = new System.Drawing.Size(129, 21);
            this.chkLowerCase.TabIndex = 0;
            this.chkLowerCase.Text = "Letras minusculas";
            this.chkLowerCase.UseVisualStyleBackColor = true;
            // 
            // decript
            // 
            this.decript.Location = new System.Drawing.Point(8, 307);
            this.decript.Name = "decript";
            this.decript.Size = new System.Drawing.Size(670, 119);
            this.decript.TabIndex = 20;
            this.decript.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Desencriptado:";
            // 
            // decriptbinary
            // 
            this.decriptbinary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decriptbinary.Location = new System.Drawing.Point(472, 434);
            this.decriptbinary.Name = "decriptbinary";
            this.decriptbinary.Size = new System.Drawing.Size(100, 33);
            this.decriptbinary.TabIndex = 14;
            this.decriptbinary.Text = "Desencriptar";
            this.decriptbinary.UseVisualStyleBackColor = true;
            this.decriptbinary.Click += new System.EventHandler(this.decriptbinary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 503);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encriptor";
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
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.RichTextBox txtDecrypt;
        private System.Windows.Forms.RichTextBox txtEncrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button encrsa;
        private System.Windows.Forms.Button desrsa;
        private System.Windows.Forms.RichTextBox txtEncryptmd5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button encripmd5;
        private System.Windows.Forms.RichTextBox txtInputmd5;
        private System.Windows.Forms.RichTextBox txtDecryptROT13;
        private System.Windows.Forms.RichTextBox txtEncryptROT13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button encriprot13;
        private System.Windows.Forms.Button decriptrot13;
        private System.Windows.Forms.RichTextBox txtInputROT13;
        private System.Windows.Forms.RichTextBox txtOutputbinary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button encripbinay;
        private System.Windows.Forms.RichTextBox txtInputbinay;
        private System.Windows.Forms.RichTextBox txtDecryptrc4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtEncryptrc4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button encriptrc4;
        private System.Windows.Forms.Button deciptrc4;
        private System.Windows.Forms.RichTextBox txtInputrc4;
        private System.Windows.Forms.TextBox txtLlave;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox txtDecrypt3des;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox txtEncrypt3des;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button encri3des;
        private System.Windows.Forms.Button decript3des;
        private System.Windows.Forms.RichTextBox txtInput3des;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCopyPass;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPasswordLength;
        private System.Windows.Forms.CheckBox chkSpecical;
        private System.Windows.Forms.CheckBox chkNumeric;
        private System.Windows.Forms.CheckBox chkUpperCase;
        private System.Windows.Forms.CheckBox chkLowerCase;
        private System.Windows.Forms.RichTextBox decript;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button decriptbinary;
    }
}

