using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;

namespace deneme
{
	public partial class musteriler: DevExpress.XtraEditors.XtraForm
	{
        public musteriler()
		{
            InitializeComponent();
            LoadOrders();

        }

        private void LoadOrders()
        {
            string connectionString = "Server=localhost;Database=stok_takip;User Id=root;Password=12345;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM orders";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                   
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}