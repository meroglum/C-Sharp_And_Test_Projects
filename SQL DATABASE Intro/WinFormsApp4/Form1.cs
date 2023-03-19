using System.Data.SqlClient;

namespace WinFormsApp4
{
    /// <summary>
    /// Lecture notes.
    /// </summary>
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
            btnClose.Click += btnClose_Click;
            btnOpen.Click += btnOpen_Click;
            // IMPORTANT:
            /// In order to use with database change below _str var.
            var _str = "Server=.;Database=AdventureWorks2019;Uid=sa;Pwd=1234567";
            conn.ConnectionString = _str; // Please change the connectivity string according to your db.
        }

        /// <summary>
        /// To open a connection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object? sender, EventArgs e)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                    lblStatus.Text = "Opened";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// To close db connection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object? sender, EventArgs e)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                    lblStatus.Text = "Closed";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpen_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}