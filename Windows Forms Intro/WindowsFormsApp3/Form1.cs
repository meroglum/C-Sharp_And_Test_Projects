using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            btnKayit.Click += BtnKayit_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cmbSehirler.Items.Add("Murtazanın Memleketi");
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            var result = GetData(
                txtKullaniciAd.Text,
                txtEmail.Text,
                txtSifre.Text,
                cmbSehirler.Text,
                rdErkek.Checked);

            string _msg = "İşlem ";
            if (result)
            {
                lblResult.Text = _msg + "başarılı.";
            }
            else
            {
                lblResult.Text = _msg + "başarısız.";
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

            string _resultMsg = Save(
                kullaniciAd, 
                email, sifre, 
                sehir, cinsiyet);
            
            if (!string.IsNullOrEmpty(_resultMsg) 
                && _resultMsg.Length >= 50)
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
            StringBuilder builder = new StringBuilder();
            builder.Append("Kullanıcı Ad : " + kullaniciAd);
            builder.Append(Environment.NewLine);
            builder.Append("Email : " + email);
            builder.Append(Environment.NewLine);
            builder.Append("Şifre : " + sifre);
            builder.Append(Environment.NewLine);
            builder.Append("Şehir : " + sehir);
            builder.Append(Environment.NewLine);
            builder.Append("Cinsiyet : " + (cinsiyet ? "Erkek" : "Kadın"));
            builder.Append(Environment.NewLine);
            return builder.ToString();
        }
    }
}
