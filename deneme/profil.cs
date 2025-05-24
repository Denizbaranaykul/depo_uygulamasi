using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;

namespace deneme
{
    public partial class profil : DevExpress.XtraEditors.XtraForm
    {
        public static string kullaniciAdi;

        public profil(string userName)
        {
            InitializeComponent();
            kullaniciAdi = userName;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=stok_takip;User Id=root;Password=12345;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = @"UPDATE admin 
                                 SET user_name = @username, 
                                     passwordd = @sifre, 
                                     email = @email 
                                 WHERE user_name = @username";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", txtIsim.Text);
                    cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
                    cmd.Parameters.AddWithValue("@email", txt_email.Text);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bilgiler güncellendi.");
                }
            }
        }

        private void profil_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=stok_takip;User Id=root;Password=12345;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM admin WHERE user_name = @username";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", kullaniciAdi);
                    connection.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtIsim.Text = reader["user_name"].ToString();
                            txt_email.Text = reader["email"].ToString();
                            txtSifre.Text = reader["passwordd"].ToString();
                        }
                    }
                }
            }
        }
    }
}