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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FullScreenDisplay();
        }

        /// <summary>
        /// Formu tam ekran yapmak iöçin
        /// </summary>
        public void FullScreenDisplay()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }
    }
}
