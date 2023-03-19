using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsThreads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }

        Random rnd;
        Thread th1;
        Thread th2;
        Thread th3;
        Thread th4;

        /// <summary>
        /// To create blue rectangles on the screen.
        /// </summary>
        public void ThreadTask01()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(
                    new Pen(Brushes.Blue, 4),
                    new Rectangle(
                        rnd.Next(0,this.ClientSize.Width),
                        rnd.Next(0, this.ClientSize.Height),
                        30,30
                        )
                    );
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// To create yellow rectangles on the screen.
        /// </summary>
        public void ThreadTask02()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(
                    new Pen(Brushes.Yellow, 4),
                    new Rectangle(
                        rnd.Next(0, this.ClientSize.Width),
                        rnd.Next(0, this.ClientSize.Height),
                        30, 30));
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// To create red rectangles on the screen.
        /// </summary>
        public void ThreadTask03()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(
                    new Pen(Brushes.Red, 4),
                    new Rectangle(
                        rnd.Next(0, this.ClientSize.Width),
                        rnd.Next(0, this.ClientSize.Height),
                        30, 30
                        )
                    );
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// To create elipses on the screen.
        /// </summary>
        public void ThreadTask04()
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();

            for (int i = 0; i < 100; i++)
            {
                formGraphics.FillEllipse(myBrush, new Rectangle(
       rnd.Next(0, this.ClientSize.Width),
            rnd.Next(0, this.ClientSize.Height),
    20, 30));
                Thread.Sleep(100);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            th1 = new Thread(ThreadTask02);
            th1.Start();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            th2 = new Thread(ThreadTask01);
            th2.Start();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            th3 = new Thread(ThreadTask03);
            th3.Start();
        }

        private void btnellipse_Click(object sender, EventArgs e)
        {
            th4= new Thread(ThreadTask04);
            th4.Start();
        }
    }
}
