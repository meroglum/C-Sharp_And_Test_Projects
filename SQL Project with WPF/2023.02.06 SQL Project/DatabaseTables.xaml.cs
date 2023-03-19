using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using System.Windows.Shapes;
using System.Configuration;

namespace _2023._02._06_SQL_Project
{
    /// <summary>
    /// Interaction logic for DatabaseTables.xaml
    /// </summary>
    public partial class DatabaseTables : Window
    {
        SqlConnection conn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["NWConnStr"].ConnectionString);
        List<Product> products = new List<Product>();
        public DatabaseTables()
        {
            InitializeComponent();
            GetProductsFromDB();
        }

        void GetProductsFromDB()
        {
            //string sql = "SELECT ProductID, ProductName FROM Products WHERE ProductID <= 5;SELECT CustomerID, CompanyName FROM Customers WHERE CustomerID LIKE 'A%'";
            string sql = "SELECT [ProductID],[ProductName],[SupplierID],[CategoryID],[QuantityPerUnit],[UnitPrice],[UnitsInStock],[UnitsOnOrder],[ReorderLevel],[Discontinued] FROM [Northwind].[dbo].[Products];";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();

                SqlDataReader rd = cmd.ExecuteReader();
                StringBuilder builder = new StringBuilder();
                while (rd.Read())
                {

                    products.Add(new Product()
                    {

                        ProductId = rd.GetInt32(0),
                        ProductName = rd.GetString(1),
                        SupplierID = rd.GetInt32(2),
                        CategoryID = rd.GetInt32(3),
                        QuantityPerUnit = rd.GetString(4),
                        UnitPrice = rd.GetDecimal(5),
                        UnitsInStock = rd.GetInt16(6),
                        UnitsOnOrder = rd.GetInt16(7),
                        ReOrderLevel = rd.GetInt16(8),
                        Discounted = rd.GetBoolean(9)
                    });
                }

                dtGridMain.ItemsSource = products;
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

        void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            //Get the ContextMenu to which the menuItem belongs
            var contextMenu = (ContextMenu)menuItem.Parent;
            //Find the placementTarget
            var item = (DataGrid)contextMenu.PlacementTarget;
            //Get the underlying item, that you cast to your object that is bound
            //to the DataGrid (and has subject and state as property)
            Product toDeleteFromBindedList = (Product)item.SelectedCells[0].Item;
            products.Remove(toDeleteFromBindedList);
            DeleteEmployees(toDeleteFromBindedList.ProductId);
            dtGridMain.ItemsSource = products;
            MessageBox.Show(toDeleteFromBindedList.ProductId.ToString());
        }

        void DeleteEmployees(int productIdToBeDeleted)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
                try
                {
                    conn.Open();
                // SQL Injection - Güvenlik için kullanılır.
                    using (cmd = new SqlCommand("Delete From [Northwind].[dbo].[Products] Where ProductID = @ProductID", conn))
                    {
                        cmd.Parameters.Add("@ProductID", SqlDbType.Int).Value = 1;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }

        /// <summary>
        /// Insert new product data to the SQL
        /// </summary>
        void InsertNewProductData()
        {
                try {
                    string sql = "INSERT INTO Products (ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued) VALUES (@ProductID,@ProductName,@SupplierID,@CategoryID,@QuantityPerUnit,@UnitPrice,@UnitsInStock,@UnitsOnOrder,@ReorderLevel,@Discontinued)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    //cmd.Parameters.AddWithValue("@FirstName", txtAd.Text);
                    //cmd.Parameters.AddWithValue("@LastName", txtSoyad.Text);
                    //cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    //cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    //cmd.Parameters.AddWithValue("@City", txtCity.Text);
                    //cmd.Parameters.AddWithValue("@TitleOfCourtesy", "Female");
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception e)
                {
                    throw e;
                }
        }
    }

    class Product
    {
        public int  ProductId { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReOrderLevel { get; set; }
        public bool Discounted { get; set; }
    }
}
