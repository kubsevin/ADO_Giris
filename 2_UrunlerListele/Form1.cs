using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_UrunlerListele
{
    public partial class Form1 : Form
    {
        private readonly string _connString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        private SqlConnection _conn;

        public Form1()
        {
            InitializeComponent();
            try
            {
                _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
            }
            catch(Exception exc)
            {
                MessageBox.Show("Connection rejected. Error message: " + exc.Message);
            }
        }

        private void btnListProducts_Click(object sender, EventArgs e)
        {
            lvProducts.Items.Clear();
            string query = "SELECT ProductName, UnitPrice, UnitsInStock FROM Products";
            
            try
            {
                SqlCommand command = new SqlCommand(query, _conn);
                _conn.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    var productName = dataReader[0];
                    var unitPrice = string.Format("${0:0.00}", dataReader[1]);
                    var unitsInStock = dataReader[2];
                    ListViewItem item = new ListViewItem(new string[] { productName.ToString(), unitPrice, unitsInStock.ToString() });
                    lvProducts.Items.Add(item);
                }
            }
            finally
            {
                _conn.Close();
            }
        }

        private void btnListCategories_Click(object sender, EventArgs e)
        {
            lbCategories.Items.Clear();
            string query = "SELECT CategoryName, Description FROM Categories";
            
            try
            {
                SqlCommand command = new SqlCommand(query, _conn);
                _conn.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    var categoryName = dataReader[0];
                    var description = dataReader[1];
                    lbCategories.Items.Add(string.Format("{0} - {1} ", categoryName, description));
                }
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
