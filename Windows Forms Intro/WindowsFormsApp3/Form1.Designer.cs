namespace WindowsFormsApp3
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.rdKadin = new System.Windows.Forms.RadioButton();
            this.rdErkek = new System.Windows.Forms.RadioButton();
            this.cmbSehirler = new System.Windows.Forms.ComboBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(289, 60);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(195, 89);
            this.txtAdres.TabIndex = 5;
            // 
            // rdKadin
            // 
            this.rdKadin.AutoSize = true;
            this.rdKadin.Location = new System.Drawing.Point(188, 158);
            this.rdKadin.Margin = new System.Windows.Forms.Padding(4);
            this.rdKadin.Name = "rdKadin";
            this.rdKadin.Size = new System.Drawing.Size(62, 20);
            this.rdKadin.TabIndex = 35;
            this.rdKadin.TabStop = true;
            this.rdKadin.Text = "Kadın";
            this.rdKadin.UseVisualStyleBackColor = true;
            // 
            // rdErkek
            // 
            this.rdErkek.AutoSize = true;
            this.rdErkek.Location = new System.Drawing.Point(113, 158);
            this.rdErkek.Margin = new System.Windows.Forms.Padding(4);
            this.rdErkek.Name = "rdErkek";
            this.rdErkek.Size = new System.Drawing.Size(63, 20);
            this.rdErkek.TabIndex = 34;
            this.rdErkek.TabStop = true;
            this.rdErkek.Text = "Erkek";
            this.rdErkek.UseVisualStyleBackColor = true;
            // 
            // cmbSehirler
            // 
            this.cmbSehirler.FormattingEnabled = true;
            this.cmbSehirler.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "Adana",
            "İzmir",
            "Antalya",
            "Balıkesir"});
            this.cmbSehirler.Location = new System.Drawing.Point(112, 124);
            this.cmbSehirler.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSehirler.Name = "cmbSehirler";
            this.cmbSehirler.Size = new System.Drawing.Size(168, 24);
            this.cmbSehirler.TabIndex = 4;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(112, 92);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(168, 24);
            this.txtSifre.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Şifre";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 60);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 24);
            this.txtEmail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Şehir";
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKayit.Location = new System.Drawing.Point(362, 187);
            this.btnKayit.Margin = new System.Windows.Forms.Padding(4);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(123, 28);
            this.btnKayit.TabIndex = 6;
            this.btnKayit.Text = "Kayıt Ol";
            this.btnKayit.UseVisualStyleBackColor = false;
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(112, 28);
            this.txtKullaniciAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAd.Multiline = true;
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(168, 24);
            this.txtKullaniciAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Kullanıcı Ad";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 210);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 235);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.rdKadin);
            this.Controls.Add(this.rdErkek);
            this.Controls.Add(this.cmbSehirler);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtKullaniciAd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.RadioButton rdKadin;
        private System.Windows.Forms.RadioButton rdErkek;
        private System.Windows.Forms.ComboBox cmbSehirler;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
    }
}

