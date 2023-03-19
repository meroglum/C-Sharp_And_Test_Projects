using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023._01._10DelegateAndEventWithWindowsForms
{
    public partial class Form1 : Form
    {
        delegate int Del(int x);
        public Form1()
        {
            InitializeComponent();

            // this.Load += Form1_Load;
            // this.DoubleClick += Form1_DoubleClick;
            this.Click += Form1_Click;
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;

            // Dinamik bir nesne üretme
            Button btn = new Button();
            TextBox textBox = new TextBox();
            CheckBox checkBox= new CheckBox();
            textBox.Text = "";
            btn.Text = "OK";
            btn.Name = "btnOK";
            btn.Width = 100;
            btn.Height = 100;
            btn.Left = btn.Width + 10;

            // btn.Click += Btn_Click;
            btn.Click += delegate (object sender, EventArgs e)
            {
                string msg = (sender as Button).Text;
                MessageBox.Show(msg);
                textBox.Text = "Butona tıklandı";
            };

            this.Controls.Add(btn);  ///Butonu formda çalıştırmak için--dinamik nesne

            textBox.Name = "textOK";
            textBox.Width = 100;
            textBox.Height = 100;
            textBox.Top = 200;

            this.Controls.Add(textBox);  ///Butonu formda çalıştırmak için--dinamik nesne

            checkBox.Checked = false;
            checkBox.Name = "checkBoxOK";
            checkBox.Width = 50;
            checkBox.Height = 50;
            checkBox.Top = 300;

            // btn.Click += Btn_Click;
            checkBox.Click += delegate (object sender, EventArgs e)
            { 
                checkBox.Checked = true;
                textBox.Text = "CheckBoxa tıklandı";
            };

            this.Controls.Add(checkBox);  ///Butonu formda çalıştırmak için--dinamik nesne

            int Hesapla(int x)
            {
                return x + x;
            }

            // Lambda Expressions
            Del myDelegate = x => x * x;
            // MessageBox.Show(myDelegate(5).ToString());

            this.Click += (s, e) => { MessageBox.Show(((MouseEventArgs)e).Location.ToString());};
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            ///Curser.Position Formu değil ekrandaki cursor position ı alır.
            // double x = Cursor.Position.X;
            // double y = Cursor.Position.Y;

            // sample code
            // Console.WriteLine("x: " + x + " y: " + y);
            //MessageBox.Show("x: " + x + " y: " + y);
            MessageBox.Show("Ekrandaki Cursor pozisonu: " +Cursor.Position.ToString()); //Ekrandaki pozisyon
            var result = ((MouseEventArgs)e).Location.ToString(); // Formdaki mause corser pozisyonunu alır
            MessageBox.Show("Fordaki cursor pozisyonu: " +result); // Ekrandaki cursor pozisyonu
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.DoubleClick -= Form1_DoubleClick;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.DoubleClick += Form1_DoubleClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Loaded");
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Çift tıklandı");
        }
    }
}
