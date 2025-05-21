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
    public partial class ürün_islem : DevExpress.XtraEditors.XtraForm
    {
        public ürün_islem()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string urunAdi = txtUrunAdi.Text;
            decimal fiyat = Convert.ToDecimal(txtFiyat.Text);
            string kategori = cmbKategori.Text;
            int stokAdedi = Convert.ToInt32(txtStokAdedi.Text);

            string connStr = "Server=localhost;Database=stok_takip;Uid=root;Pwd=12345";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO urunler (urun_adi, fiyat, kategori, stok_adedi) VALUES (@adi, @fiyat, @kategori, @stok)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@adi", urunAdi);
                        cmd.Parameters.AddWithValue("@fiyat", fiyat);
                        cmd.Parameters.AddWithValue("@kategori", kategori);
                        cmd.Parameters.AddWithValue("@stok", stokAdedi);
                        cmd.ExecuteNonQuery();
                    }

                    DevExpress.XtraEditors.XtraMessageBox.Show("Ürün başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Close();
            }
        }

        private void ürün_islem_Load(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;Database=stok_takip;Uid=root;Pwd=12345";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM urunler";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridControl1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}