using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace deneme
{
    public partial class customer : DevExpress.XtraEditors.XtraForm
    {
      
        public customer()
        {
            InitializeComponent();
            
        }
        public static double order = 0.0;

        public static void lblorder(LabelControl label)
        {
            label.Text = order + " TL";
        }
        private void sold(string urunAdi)
        {
            string connectionString = "Server=localhost;Database=stok_takip;Uid=root;Pwd=12345";
            string updateQuery = "UPDATE urunler SET stok_adedi = stok_adedi - 1 WHERE urun_adi = @urunAdi";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@urunAdi", urunAdi);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    
                }
            }
            int Urun_id;
            string sql = "SELECT id FROM urunler WHERE urun_adi = @urunAdi";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@urunAdi", urunAdi);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Urun_id = Convert.ToInt32(reader["id"]);
                        }
                        else
                        {
                            MessageBox.Show("Ürün bulunamadı.");
                            return;
                        }
                    }
                }
            }
            string query = "INSERT INTO orders(user_id,product_id,quantity) VALUES(@user,@product,@quan)";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", Form1.GLobalDatabase.dt.Rows[0]["id"]);
                    cmd.Parameters.AddWithValue("@product",Urun_id);
                    cmd.Parameters.AddWithValue("@quan", 1);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void reduce(string urunAdi)
        {
            string connectionString = "Server=localhost;Database=stok_takip;Uid=root;Pwd=12345";
            string selectQuery = "SELECT fiyat FROM urunler WHERE urun_adi = @urunAdi";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@urunAdi", urunAdi);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            double cost = Convert.ToDouble(reader["fiyat"]);
                            order =order- cost;
                        }
                    }
                }
            }
        }



        private void ShowProductByName(string urunAdi)
        {
            string connectionString = "Server=localhost;Database=stok_takip;Uid=root;Pwd=12345";
            string query = "SELECT urun_adi, fiyat, explation, foto FROM urunler WHERE urun_adi = @urunAdi";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@urunAdi", urunAdi);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader["urun_adi"].ToString();
                            string cost = Convert.ToDecimal(reader["fiyat"]).ToString("C2");
                            string explanation = reader["explation"].ToString();

                            Image art = null;

                            if (!reader.IsDBNull(reader.GetOrdinal("foto")))
                            {
                                byte[] imageBytes = (byte[])reader["foto"];
                                if (imageBytes != null && imageBytes.Length > 0)
                                {
                                    try
                                    {
                                        using (MemoryStream ms = new MemoryStream(imageBytes))
                                        {
                                            ms.Position = 0;
                                            using (Image tempImage = Image.FromStream(ms))
                                            {
                                                art = new Bitmap(tempImage);
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Resim işlenirken hata: " + ex.Message);
                                    }
                                }
                            }



                            showdialog(name, cost, explanation, art);
                        }
                        else
                        {
                            MessageBox.Show("Ürün bulunamadı.");
                        }
                    }
                }
            }
        }

        static void showdialog(string name,string cost,string explantion,Image art)
        {
            dialoggg dialogg = new dialoggg();
            dialogg.Picture = art;
            dialogg.Label2Text = cost;
            dialogg.Label3Text = name;
            dialogg.Richtextbox = explantion;
            dialogg.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
          ShowProductByName("iphone 14");
        }


        private void simpleButton4_Click(object sender, EventArgs e)
        {
            ShowProductByName("laptop");
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            ShowProductByName("ofis masası");
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            ShowProductByName("şampuan");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ShowProductByName("iPad Air M3");
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            ShowProductByName("playstation 5");
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            ShowProductByName("xbox one s");
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            ShowProductByName("playstation 5 kolu");
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            ShowProductByName("ispanyol paça pantolon");
        }

        private void simpleButton28_Click(object sender, EventArgs e)
        {
            ShowProductByName("çocuk elbise");
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
           ShowProductByName("kumaş pantolon");
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            ShowProductByName("spor ayakkabı");
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            ShowProductByName("gömlek");
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            ShowProductByName("converse ayakkabı");
        }

        private void simpleButton27_Click(object sender, EventArgs e)
        {
            ShowProductByName("elbise");
        }

        private void simpleButton26_Click(object sender, EventArgs e)
        {
            ShowProductByName("elbise");
        }

        private void simpleButton29_Click(object sender, EventArgs e)
        {
            ShowProductByName("topuklu ayakkabı");
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            ShowProductByName("çorap");
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            ShowProductByName("mutfak masası");
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
           ShowProductByName("oturma grubu");
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
           ShowProductByName("gardırop");
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            ShowProductByName("parfüm");
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
           ShowProductByName("saç köpüğü"); 
        }

        private void simpleButton20_Click(object sender, EventArgs e)
        {
          ShowProductByName("saç kremi");
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            ShowProductByName("sırt çantası");
        }

        private void simpleButton24_Click(object sender, EventArgs e)
        {
            ShowProductByName("kalem");
        }

        private void simpleButton23_Click(object sender, EventArgs e)
        {
            ShowProductByName("defter");
        }

        private void simpleButton25_Click(object sender, EventArgs e)
        {
            ShowProductByName("kalem kutu");
        }






        private void ürünDetayGoster() // örnek fonksiyon
        {
            dialoggg dlg = new dialoggg();
            dlg.AnaForm = this; // Şu anki formu referans olarak verdik
            dlg.Label3Text = "Örnek Ürün Adı";
            dlg.ShowDialog();
        }

        private void customer_Load(object sender, EventArgs e)
        {
            lblorder(lbl_orderr);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<listBoxControl1.ItemCount;i++)
            {
                sold(listBoxControl1.Items[i].ToString());
            }

            listBoxControl1.Items.Clear();
            Form1.customerForm.lbl_orderr.Text = "0,00 TL";
        }

        private void simpleButton30_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
            this.Hide();
        }

        private void listBoxControl1_DoubleClick(object sender, EventArgs e)
        {
            int index = listBoxControl1.SelectedIndex;
            if (index >= 0)
            {
                reduce(listBoxControl1.Items[index].ToString());
                lblorder(lbl_orderr);
                listBoxControl1.Items.RemoveAt(index);
            }
        }
    }
}



