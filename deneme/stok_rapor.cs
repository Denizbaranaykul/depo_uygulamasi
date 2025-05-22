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
using DevExpress.XtraCharts;
using MySql.Data.MySqlClient;

namespace deneme
{
	public partial class stok_rapor: DevExpress.XtraEditors.XtraForm
	{
        public stok_rapor()
		{
            InitializeComponent();
		}

        private void stok_rapor_Load(object sender, EventArgs e)
        {

            // Veritabanı bağlantı cümlesi
            string connStr = "Server=localhost;Database=stok_takip;Uid=root;Pwd=12345";

            // DataTable oluşturuluyor
            DataTable dt = new DataTable();
            dt.Columns.Add("urun_adi", typeof(string));
            dt.Columns.Add("stok_adedi", typeof(int));

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT urun_adi, stok_adedi FROM urunler";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string urunAdi = reader["urun_adi"].ToString();
                        int stok = Convert.ToInt32(reader["stok_adedi"]);
                        dt.Rows.Add(urunAdi, stok);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    return;
                }
            }

            // Grafik verisini bağla
            chartControl1.DataSource = dt;

            // Seri oluştur
            Series seri = new Series("Stoklar", ViewType.StackedBar);
            seri.ArgumentDataMember = "urun_adi"; // X ekseni
            seri.ValueDataMembers.AddRange("stok_adedi"); // Y ekseni

            // Grafik temizle ve yeni seriyi ekle
            chartControl1.Series.Clear();
            chartControl1.Series.Add(seri);

            // Başlık ekle (isteğe bağlı)
            ChartTitle title = new ChartTitle();
            title.Text = "Ürün Stok Durumu";
            chartControl1.Titles.Clear();
            chartControl1.Titles.Add(title);
        }
    }
}
    
