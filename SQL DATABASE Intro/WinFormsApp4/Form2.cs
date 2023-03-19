using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace WinFormsApp4
{
    /// <summary>
    /// This is the lecture note.
    /// </summary>
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["NWConnStr"].ConnectionString);
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            // Todo Implement get report.
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Todo implement clear button.
        }

        /// <summary>
        /// Gets the numbers of the records.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExecuteScalar_Click(object sender, EventArgs e)
        {
            ExecuteScalar();
        }

        /// <summary>
        /// Gets data from SQL.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExecuteReader_Click(object sender, EventArgs e)
        {
            ExecuteReaderNextResult();
            InsertData();
        }

        private void btnExecuteProcedure_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Gets numbers of the records in a SQL table.
        /// </summary>
        void ExecuteScalar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(ProductID) FROM Products"; // SQL ref.

                conn.Open(); // open connection to the db.

                string s = cmd.ExecuteScalar().ToString(); // gets number of records.
                txtResult.Text = s + " kayit bulundu!";

                conn.Close(); // After we are done with it close the connection.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Gets the SQL table records.
        /// </summary>
        void ExecuteReaderNextResult()
        {
            string sql = "SELECT EmployeeID, FirstName FROM Employees WHERE EmployeeID <= 10;";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();

                SqlDataReader rd = cmd.ExecuteReader();
                StringBuilder builder = new StringBuilder();
                while (rd.Read())
                {
                    builder.Append("*********");
                    builder.Append(Environment.NewLine);
                    builder.Append("Urun No:");
                    builder.Append(rd[0]);
                    builder.Append(Environment.NewLine);
                    builder.Append("Urun Ad:");
                    builder.Append(rd[1]);
                    builder.Append(Environment.NewLine);
                }

                txtResult.Text = builder.ToString();
          
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// To insert data.
        /// </summary>
        void InsertData()
        {
            String query = "INSERT INTO dbo.SMS_PW (EmployeeID) VALUES (@EmployeeID)";
            string sql = "INSERT INTO Employees (FirstName,LastName) VALUES (@FirstName,@LastName)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            cmd.Parameters.AddWithValue("@FirstName", "abc");
            cmd.Parameters.AddWithValue("@LastName", "abc");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
