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

namespace ADO_Giris
{
    public partial class Form1 : Form
    {
        private SqlConnection _conn;

        public Form1()
        {
            InitializeComponent();
            try
            {
                _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
            }
            catch(ApplicationException exc)
            {
                MessageBox.Show("An error occured. Error Message: " + exc.Message);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
                MessageBox.Show("Connection opened");
            }
            else
            {
                MessageBox.Show("Connection is already opened");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_conn.State == ConnectionState.Open)
            {
                _conn.Close();
                MessageBox.Show("Connection closed");
            }
            else
            {
                MessageBox.Show("Connection is already closed");
            }
        }

        private void btnOpenOrClose_Click(object sender, EventArgs e)
        {
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
                MessageBox.Show("Connection opened");
            }
            else
            {
                _conn.Close();
                MessageBox.Show("Connection closed");
            }
        }
    }
}
