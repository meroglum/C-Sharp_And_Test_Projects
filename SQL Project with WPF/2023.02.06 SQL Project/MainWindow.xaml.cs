using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

//Created By Muhammed EROGLU
namespace _2023._02._06_SQL_Project
{
    public partial class MainWindow : Window
    {
        /// <summary>
        // Change connection string to connect SQL database.
        /// </summary>
        SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["NWConnStr"].ConnectionString);
       
        public MainWindow()
        {
            InitializeComponent();
            btnSignIn.Click += BtnSignIn_Click;
        }

         private async void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            signInButtonStateChange(true); // disable inputs.
            await PutTaskDelay();
            CheckLogin();
        }

        /// <summary>
        /// Checks if the login input fields are filled properly.
        /// </summary>
        /// <returns></returns>
        bool CheckFieldsAreFilled()
        {
            bool requiredFieldsAreFilled = false;
            if (!string.IsNullOrEmpty(txtUsername.Text))
                lblUsernameError.Text = "";
            else
                lblUsernameError.Text = ConstantStrings.loginTxtBoxNotFilledError;

            if (!string.IsNullOrEmpty(txtPassword.Password))
                lblPasswordError.Text = "";
            else
                lblPasswordError.Text = ConstantStrings.loginTxtBoxNotFilledError;

            if(!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Password))
                requiredFieldsAreFilled = true;

            return requiredFieldsAreFilled;
        }

        /// <summary>
        /// Search database for if the current user exists.
        /// </summary>
        public void CheckLogin()
        {
            bool successfulSignIn = default; // bool value of false.
            if (CheckFieldsAreFilled())
            {
                string sql = "SELECT [FirstName], [LastName] FROM [Northwind].[dbo].[Employees] WHERE FirstName = '"+ txtUsername.Text +"';";
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    string _username = string.Empty;
                    string _password = string.Empty;

                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        _username = rd.GetString(0);
                        _password = rd.GetString(1); // Password is Lastname on the DB.
                    }
                    successfulSignIn = CheckUsernameAndPassword(_username, _password);
                     
                }
                catch (Exception ex)
                {
                    signInButtonStateChange(false);
                    MessageBox.Show("HATA: " + ex.Message);
                }
                finally
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
            if (successfulSignIn)
                navigateToDatabaseScreen();

            signInButtonStateChange(successfulSignIn); // Enable or disable input fields.
        }

        /// <summary>
        /// It checks and returns a bool depending on the database value.
        /// </summary>
        /// <returns></returns>
        /// TODO Additional controls can be added i.e. Username does not exist.
        bool CheckUsernameAndPassword(string username, string password)
        {
            bool userAccessGranted = false;
            lblLoginError.Text = string.Empty;
            if (txtUsername.Text == username && txtPassword.Password == password)
                userAccessGranted = true;
            else 
                lblLoginError.Text = ConstantStrings.loginButtonSignInError;
            return userAccessGranted;
        }

        /// <summary>
        /// Change the state of the sign in button and textInputs according to the login.
        /// </summary>
        void signInButtonStateChange(bool signingIn)
        {
            if (signingIn)
            {
                btnSignIn.Content = "Lütfen Bekleyiniz";
                btnSignIn.IsEnabled = false;
                txtUsername.IsEnabled = false;
                txtPassword.IsEnabled = false;
            }
            else
            {
                btnSignIn.Content = "Giriş Yap";
                btnSignIn.IsEnabled = true;
                txtUsername.IsEnabled = true;
                txtPassword.IsEnabled = true;
            }
        }

        /// <summary>
        /// To simulate the login latancy.
        /// check: https://stackoverflow.com/questions/22158278/wait-some-seconds-without-blocking-ui-execution
        /// </summary>
        async Task PutTaskDelay()
        {
            if (CheckFieldsAreFilled())
                await Task.Delay(5000);
            else
                await Task.Delay(0);
        }

        /// <summary>
        /// To navigate when the user successfully logins.
        /// </summary>
        void navigateToDatabaseScreen()
        {
            DatabaseTables databaseTables = new DatabaseTables(); //create your new page.
            databaseTables.Show(); // show the new page.
            this.Close(); // Close the current page.
        }

    }
}
