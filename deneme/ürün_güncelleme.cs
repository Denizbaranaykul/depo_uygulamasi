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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using MySql.Data.MySqlClient;

namespace deneme
{
    public partial class ürün_güncelleme : DevExpress.XtraEditors.XtraForm
    {
        public ürün_güncelleme()
        {
            InitializeComponent();
        }

        private void ürün_güncelleme_Load(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;Database=stok_takip;Uid=root;Pwd=12345";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, urun_adi FROM urunler";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        XtraMessageBox.Show("Ürün tablosu boş!");
                        return;
                    }

                    lookUpUrunler.Properties.DataSource = dt;
                    lookUpUrunler.Properties.DisplayMember = "urun_adi";
                    lookUpUrunler.Properties.ValueMember = "id";
                    lookUpUrunler.Properties.NullText = "Ürün Seçiniz...";

                    lookUpUrunler.Properties.Columns.Clear();
                    lookUpUrunler.Properties.Columns.Add(new LookUpColumnInfo("urun_adi", "Ürün Adı"));

                    lookUpUrunler.EditValue = null;
                    lookUpUrunler.EditValueChanged += lookUpUrunler_EditValueChanged;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void lookUpUrunler_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpUrunler.EditValue == null)
                return;

            int urunId = Convert.ToInt32(lookUpUrunler.EditValue);
            string connStr = "Server=localhost;Database=stok_takip;Uid=root;Pwd=12345";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM urunler WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", urunId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtUrunAdi.Text = reader["urun_adi"].ToString();
                        numericFiyat.Value = Convert.ToDecimal(reader["fiyat"]);
                        numericStok.Value = Convert.ToInt32(reader["stok_adedi"]);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lookUpUrunler.EditValue == null)
            {
                XtraMessageBox.Show("Lütfen bir ürün seçin.");
                return;
            }

            int urunId = Convert.ToInt32(lookUpUrunler.EditValue);
            string urunAdi = txtUrunAdi.Text;
            decimal fiyat = numericFiyat.Value;
            int stok = (int)numericStok.Value;

            string connStr = "Server=localhost;Database=stok_takip;Uid=root;Pwd=12345";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE urunler SET urun_adi=@adi, fiyat=@fiyat, stok_adedi=@stok WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@adi", urunAdi);
                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                    cmd.Parameters.AddWithValue("@stok", stok);
                    cmd.Parameters.AddWithValue("@id", urunId);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                        XtraMessageBox.Show("Ürün başarıyla güncellendi.");
                    else
                        XtraMessageBox.Show("Güncelleme başarısız!");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Güncelleme sırasında hata: " + ex.Message);
                }
            }
        }
    }
}
