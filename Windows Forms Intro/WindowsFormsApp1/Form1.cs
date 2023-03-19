using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        delegate int Del(int x);
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            /*this.DoubleClick += Form1_DoubleClick*/;
            //this.Click += Form1_Click;

            // Buttons
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;

            // Dinamik Bir Nesne Üretmek!
            Button btn = new Button();
            btn.Text = "OK!";
            btn.Name = "btnOk";
            btn.Width = 100;
            btn.Height = 100;
            btn.Left = btn.Width + 10;
            //btn.Click += Btn_Click;
            btn.Click += delegate (object sender, EventArgs e)
            {
                string msg = (sender as Button).Text;
                MessageBox.Show(msg);
            };
            //this.Controls.Add(btn);

            // Lambda Expressions
            Del myDelegate = x => x * x;
            //MessageBox.Show(myDelegate(5).ToString());

            //
            this.Click += (s, e) => { MessageBox.Show("X: " + ((MouseEventArgs)e).Location.ToString()); };
        }

        int Hesapla(int x) 
        { 
            return x * x; 
        }

        //private void Btn_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Test");
        //}

        private void Form1_Click(object sender, EventArgs e)
        {
            // Gökhan (yanlış)
            //MessageBox.Show(Cursor.Position.ToString());

            // Gizem (yanlış)
            // aynı

            // Muhammed (yanlış)
            //double x, double y = Cursor.Position.X, Cursor.Position.Y;

            // Cafer
            // doğru

            var result = ((MouseEventArgs)e).Location.ToString();
            MessageBox.Show(result);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //this.DoubleClick += Form1_DoubleClick;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //this.DoubleClick -= Form1_DoubleClick;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Çift tıklandı!");
        }

        void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Loaded!");
        }
    }
}
