using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023._01._11WindoesFormLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            buttonLogin.Click += ButtonLoginClick;// Initialize button click

        }

        /// <summary>
        /// Giriş butonu ile kullanıcı adı ve şifre kontrolü sağla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLoginClick(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "muhammed" && textBoxPassword.Text == "123456")
            {
                MessageBox.Show("Başarılı bir şekilde giriş yapıldı.");
                Form2 form2= new Form2();
                form2.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Lütfen giriş bilgilerinizi kontrol ediniz.");
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
