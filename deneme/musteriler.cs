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
    public partial class musteriler : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
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
                string query = @"
                SELECT 
                    CONCAT(customer.first_name, ' ', customer.last_name) AS musteri_adi,
                    urunler.urun_adi,
                    DATE(orders.order_date) AS siparis_tarihi,
                    SUM(orders.quantity) AS toplam_adet
                FROM orders
                JOIN customer ON orders.user_id = customer.id
                JOIN urunler ON orders.product_id = urunler.id
                GROUP BY customer.id, urunler.id, DATE(orders.order_date)";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }

            // Görünüm ayarları
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();

        }
    }
}