namespace _2023._01._20BusinessApp
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chcBuyIt = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPhoneTypeError = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.labelSkt = new System.Windows.Forms.Label();
            this.txtSKTMonth = new System.Windows.Forms.TextBox();
            this.lblSKTDivider = new System.Windows.Forms.Label();
            this.txtSKTYear = new System.Windows.Forms.TextBox();
            this.lblCVC = new System.Windows.Forms.Label();
            this.txtSKT_CVC = new System.Windows.Forms.TextBox();
            this.lblPaynentMethodDoesNotExist = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBasketTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnSaveUserDetails = new System.Windows.Forms.Button();
            this.lblBuyBtnError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(107, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Detayları";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(78, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yıllık Abonelik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(208, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "₺";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(117, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 52);
            this.label4.TabIndex = 3;
            this.label4.Text = "499";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(55, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "*İptal edilmediği sürece yıllık yenilenir";
            // 
            // chcBuyIt
            // 
            this.chcBuyIt.AutoSize = true;
            this.chcBuyIt.Location = new System.Drawing.Point(140, 185);
            this.chcBuyIt.Name = "chcBuyIt";
            this.chcBuyIt.Size = new System.Drawing.Size(74, 20);
            this.chcBuyIt.TabIndex = 5;
            this.chcBuyIt.Text = "Satın Al";
            this.chcBuyIt.UseVisualStyleBackColor = true;
            this.chcBuyIt.CheckedChanged += new System.EventHandler(this.ChcBuyIt_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(486, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ödeme Yöntemi";
            // 
            // lblPhoneTypeError
            // 
            this.lblPhoneTypeError.AutoSize = true;
            this.lblPhoneTypeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneTypeError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneTypeError.Location = new System.Drawing.Point(632, 60);
            this.lblPhoneTypeError.Name = "lblPhoneTypeError";
            this.lblPhoneTypeError.Size = new System.Drawing.Size(0, 16);
            this.lblPhoneTypeError.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(487, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 16);
            this.label13.TabIndex = 53;
            this.label13.Text = "Ödeme Tipii*";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(490, 79);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(222, 24);
            this.cmbPaymentMethod.TabIndex = 52;
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.CmbPaymentMethod_SelectedIndexChanged);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(490, 140);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(222, 22);
            this.txtCardNumber.TabIndex = 55;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(487, 121);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(114, 16);
            this.lblCardNumber.TabIndex = 56;
            this.lblCardNumber.Text = "Kart Numarasıi*";
            // 
            // labelSkt
            // 
            this.labelSkt.AutoSize = true;
            this.labelSkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSkt.Location = new System.Drawing.Point(487, 166);
            this.labelSkt.Name = "labelSkt";
            this.labelSkt.Size = new System.Drawing.Size(42, 16);
            this.labelSkt.TabIndex = 58;
            this.labelSkt.Text = "SKT*";
            // 
            // txtSKTMonth
            // 
            this.txtSKTMonth.Location = new System.Drawing.Point(490, 185);
            this.txtSKTMonth.Name = "txtSKTMonth";
            this.txtSKTMonth.Size = new System.Drawing.Size(40, 22);
            this.txtSKTMonth.TabIndex = 57;
            // 
            // lblSKTDivider
            // 
            this.lblSKTDivider.AutoSize = true;
            this.lblSKTDivider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSKTDivider.Location = new System.Drawing.Point(536, 189);
            this.lblSKTDivider.Name = "lblSKTDivider";
            this.lblSKTDivider.Size = new System.Drawing.Size(12, 16);
            this.lblSKTDivider.TabIndex = 59;
            this.lblSKTDivider.Text = "/";
            // 
            // txtSKTYear
            // 
            this.txtSKTYear.Location = new System.Drawing.Point(554, 186);
            this.txtSKTYear.Name = "txtSKTYear";
            this.txtSKTYear.Size = new System.Drawing.Size(40, 22);
            this.txtSKTYear.TabIndex = 60;
            // 
            // lblCVC
            // 
            this.lblCVC.AutoSize = true;
            this.lblCVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVC.Location = new System.Drawing.Point(670, 166);
            this.lblCVC.Name = "lblCVC";
            this.lblCVC.Size = new System.Drawing.Size(43, 16);
            this.lblCVC.TabIndex = 61;
            this.lblCVC.Text = "CVC*";
            // 
            // txtSKT_CVC
            // 
            this.txtSKT_CVC.Location = new System.Drawing.Point(672, 185);
            this.txtSKT_CVC.Name = "txtSKT_CVC";
            this.txtSKT_CVC.Size = new System.Drawing.Size(40, 22);
            this.txtSKT_CVC.TabIndex = 62;
            // 
            // lblPaynentMethodDoesNotExist
            // 
            this.lblPaynentMethodDoesNotExist.AutoSize = true;
            this.lblPaynentMethodDoesNotExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaynentMethodDoesNotExist.ForeColor = System.Drawing.Color.Red;
            this.lblPaynentMethodDoesNotExist.Location = new System.Drawing.Point(460, 106);
            this.lblPaynentMethodDoesNotExist.Name = "lblPaynentMethodDoesNotExist";
            this.lblPaynentMethodDoesNotExist.Size = new System.Drawing.Size(277, 16);
            this.lblPaynentMethodDoesNotExist.TabIndex = 63;
            this.lblPaynentMethodDoesNotExist.Text = "Ödeme yöntemi ülkenizde mevcut değil";
            this.lblPaynentMethodDoesNotExist.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(486, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 24);
            this.label7.TabIndex = 64;
            this.label7.Text = "Sepet Toplamı";
            // 
            // lblBasketTotal
            // 
            this.lblBasketTotal.AutoSize = true;
            this.lblBasketTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasketTotal.ForeColor = System.Drawing.Color.Black;
            this.lblBasketTotal.Location = new System.Drawing.Point(481, 258);
            this.lblBasketTotal.Name = "lblBasketTotal";
            this.lblBasketTotal.Size = new System.Drawing.Size(47, 52);
            this.lblBasketTotal.TabIndex = 66;
            this.lblBasketTotal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(572, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 31);
            this.label9.TabIndex = 65;
            this.label9.Text = "₺";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(31, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 15);
            this.label8.TabIndex = 67;
            this.label8.Text = "Kişisel Lisans Bilgileri";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(31, 295);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(23, 15);
            this.lblName.TabIndex = 68;
            this.lblName.Text = "Ad";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.Black;
            this.lblSurname.Location = new System.Drawing.Point(31, 310);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(46, 15);
            this.lblSurname.TabIndex = 69;
            this.lblSurname.Text = "Soyad";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(34, 360);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(43, 15);
            this.lblAddress.TabIndex = 70;
            this.lblAddress.Text = "Adres";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.Black;
            this.lblCity.Location = new System.Drawing.Point(31, 403);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(41, 15);
            this.lblCity.TabIndex = 71;
            this.lblCity.Text = "Şehir";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.Black;
            this.lblCountry.Location = new System.Drawing.Point(31, 426);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(36, 15);
            this.lblCountry.TabIndex = 72;
            this.lblCountry.Text = "Ülke";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(31, 325);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 15);
            this.lblPhone.TabIndex = 73;
            this.lblPhone.Text = "Telefon";
            // 
            // btnSaveUserDetails
            // 
            this.btnSaveUserDetails.BackColor = System.Drawing.Color.Ivory;
            this.btnSaveUserDetails.FlatAppearance.BorderColor = System.Drawing.Color.Ivory;
            this.btnSaveUserDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSaveUserDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUserDetails.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveUserDetails.Location = new System.Drawing.Point(554, 368);
            this.btnSaveUserDetails.Name = "btnSaveUserDetails";
            this.btnSaveUserDetails.Size = new System.Drawing.Size(159, 50);
            this.btnSaveUserDetails.TabIndex = 74;
            this.btnSaveUserDetails.Text = "Satın Al";
            this.btnSaveUserDetails.UseVisualStyleBackColor = false;
            this.btnSaveUserDetails.Click += new System.EventHandler(this.btnSaveUserDetails_Click);
            // 
            // lblBuyBtnError
            // 
            this.lblBuyBtnError.AutoSize = true;
            this.lblBuyBtnError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyBtnError.ForeColor = System.Drawing.Color.Red;
            this.lblBuyBtnError.Location = new System.Drawing.Point(517, 337);
            this.lblBuyBtnError.Name = "lblBuyBtnError";
            this.lblBuyBtnError.Size = new System.Drawing.Size(196, 16);
            this.lblBuyBtnError.TabIndex = 75;
            this.lblBuyBtnError.Text = "Lütfen en az bir ürün seçiniz";
            this.lblBuyBtnError.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBuyBtnError);
            this.Controls.Add(this.btnSaveUserDetails);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblBasketTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPaynentMethodDoesNotExist);
            this.Controls.Add(this.txtSKT_CVC);
            this.Controls.Add(this.lblCVC);
            this.Controls.Add(this.txtSKTYear);
            this.Controls.Add(this.lblSKTDivider);
            this.Controls.Add(this.labelSkt);
            this.Controls.Add(this.txtSKTMonth);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblPhoneTypeError);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chcBuyIt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chcBuyIt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPhoneTypeError;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label labelSkt;
        private System.Windows.Forms.TextBox txtSKTMonth;
        private System.Windows.Forms.Label lblSKTDivider;
        private System.Windows.Forms.TextBox txtSKTYear;
        private System.Windows.Forms.Label lblCVC;
        private System.Windows.Forms.TextBox txtSKT_CVC;
        private System.Windows.Forms.Label lblPaynentMethodDoesNotExist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBasketTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnSaveUserDetails;
        private System.Windows.Forms.Label lblBuyBtnError;
    }
}