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
	public partial class ürün_silme: DevExpress.XtraEditors.XtraForm
	{
        public ürün_silme()
		{
            InitializeComponent();
		}

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                int urunID = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id"));

                DialogResult result = MessageBox.Show("Seçili ürünü silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string connStr = "Server=localhost;Database=stok_takip;Uid=root;Pwd=12345";
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        try
                        {
                            conn.Open();
                            string sql = "DELETE FROM urunler WHERE id = @id";
                            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", urunID);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Ürün başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ürün_silme_Load(null, null); // tabloyu yenile
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir ürün seçin.");
            }
        }

        private void ürün_silme_Load(object sender, EventArgs e)
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
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}