using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace _2023._02._02DATABASE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection conn = new SqlConnection(
          ConfigurationManager.ConnectionStrings["NWConnStr"].ConnectionString);
        public MainWindow()
        {
            InitializeComponent();
            btnKaydet.Click += BtnKaydet_Click;
            btnSil.Click += BtnSil_Click;
            GetEmployeesFromDB();
            GetEmployeeCount();
        }

        private void BtnSil_Click(object sender, RoutedEventArgs e)
        {
            DeleteEmployees();
        }

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            InsertNewEmployeeData();
        }

        /// <summary>
        /// Insert new employee data to the SQL
        /// </summary>
        void InsertNewEmployeeData()
        {
            if (string.IsNullOrEmpty(txtAd.Text) == false || string.IsNullOrEmpty(txtAd.Text) == false)
            {
                try
                {
                    string sql = "INSERT INTO Employees (FirstName,LastName,Title,Address,City) VALUES (@FirstName,@LastName,@Title,@Address,@City)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    ///TODO Do not use controllers for parameters.
                    cmd.Parameters.AddWithValue("@FirstName", txtAd.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@City", txtCity.Text);
                    cmd.Parameters.AddWithValue("@TitleOfCourtesy", "Female");
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    ClearFieldValues();
                    GetEmployeesFromDB();
                    GetEmployeeCount();
                }catch(Exception e)
                {
                    throw e;
                }
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz");
            }
      
        }

        /// <summary>
        /// It gets employee info from db.
        /// </summary>
        void GetEmployeesFromDB()
        {
            string sql = "SELECT TOP (1000) [EmployeeID] ,[LastName] ,[FirstName],[Title],[TitleOfCourtesy],[BirthDate],[HireDate],[Address],[City],[Region],[PostalCode],[Country],[HomePhone],[Extension],[Photo],[Notes],[ReportsTo],[PhotoPath]  FROM [Northwind].[dbo].[Employees];";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();

                SqlDataReader rd = cmd.ExecuteReader();
                StringBuilder builder = new StringBuilder();
                while (rd.Read())
                {
                    builder.Append("*********************************");
                    builder.Append(Environment.NewLine);
                    builder.Append("Adı Soyadı: " + rd[2] + rd[1]);
                    builder.Append("\n");
                    builder.Append("Cinsiyeti: " + rd[5]);
                    builder.Append("\n");
                    builder.Append("Açık Adres: " + rd[7]);
                    builder.Append("\n");
                    builder.Append("Şehir: " + rd[8]);
                    builder.Append(Environment.NewLine);
                }

                txtSQLData.Text = builder.ToString();

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
        /// To get the number of the employees.
        /// </summary>
        void GetEmployeeCount()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(EmployeeID) FROM Employees";

                conn.Open();

                string count = cmd.ExecuteScalar().ToString();
                txtEmoloyeeCount.Text = count + " calisan mevcut";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// To delete an employee record.
        /// </summary>
        void DeleteEmployees()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            if (!string.IsNullOrEmpty(txtDeleteEmployeeID.Text))
            {
                try
                {
                    conn.Open();
                    using (cmd = new SqlCommand("Delete From Employees Where EmployeeID = @EmployeeID", conn))
                    {
                        cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = int.Parse(txtDeleteEmployeeID.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        GetEmployeesFromDB();
                        GetEmployeeCount();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("Lütfen çalışan ID giriniz.");
            }
        }

        /// <summary>
        /// To clear field values after a new employee is saved.
        /// </summary>
        void ClearFieldValues()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtTitle.Text = "";
            rdMale.IsChecked = true;
        }

        private void btnDuzenle_Click(object sender, RoutedEventArgs e)
        {
            /// TODO düzenle bölümünü tamamla
        }
    }
}
