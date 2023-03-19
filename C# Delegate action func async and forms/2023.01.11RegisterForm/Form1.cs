using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023._01._11RegisterForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnRegister.Click += BtnKayit_Click;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            var result = GetData(
                txtUsername.Text,
                txtEmail.Text,
                txtPassword.Text,
                cmbCity.Text,
                rdErkek.Checked);

            string _msg = "İşlem";
            if (result)
            {
                lblResult.Text = _msg + " Başarılı";
            }
            else
            {
                lblResult.Text = _msg + " Başarısız";
            }
        }

        private bool GetData(
          string kullaniciAd,
            string email,
            string sifre,
            string sehir,
            bool cinsiyet)
        {
            bool result = new bool();
            string _result = Save(
                kullaniciAd,email,sifre,sehir,cinsiyet);
            if (!string.IsNullOrEmpty(_result) && _result.Length >= 50)
            {
                result = true;
            }
            return result;
        }

        private string Save(
            string kullaniciAd,
            string email,
            string sifre,
            string sehir,
            bool cinsiyet)
        {
            StringBuilder builder= new StringBuilder();
            builder.Append("Kullanıcı Ad: " + kullaniciAd);
            builder.Append(Environment.NewLine);
            builder.Append("Email: " + email);
            builder.Append(Environment.NewLine);
            builder.Append("Şifre: " + sifre);
            builder.Append(Environment.NewLine);
            builder.Append("Şehir: " + sehir);
            builder.Append(Environment.NewLine);
            builder.Append("Cinsiyet: " + (cinsiyet ? "Erkek" : "Kadın"));
            builder.Append(Environment.NewLine);
            return builder.ToString();
        }
    }
}
