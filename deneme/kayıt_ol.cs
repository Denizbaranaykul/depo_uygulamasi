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
	public partial class kayıt_ol: DevExpress.XtraEditors.XtraForm
	{
        public kayıt_ol()
		{
            InitializeComponent();
		}

        private void simpleButton_kaydı_tamamla_Click(object sender, EventArgs e)
        {
            // Kontrollerin değerlerini al
            string userName = txt_user_name_customer.Text.Trim();
            string password = txt_password_customer.Text.Trim();
            string passwordRepeat = txt_password_customer_repeat.Text.Trim();
            string phone = txt_phone.Text.Trim();
            string firstName = txt_first_name.Text.Trim();
            string lastName = txt_last_name.Text.Trim();

            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(userName) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(passwordRepeat) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Şifre kontrolü
            if (password != passwordRepeat)
            {
                MessageBox.Show("Şifreler uyuşmuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=stok_takip;Uid=root;Pwd=12345"))
                {
                    conn.Open();

                    // Aynı kullanıcı adı var mı kontrolü
                    string checkQuery = "SELECT COUNT(*) FROM customer WHERE user_name = @user_name";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@user_name", userName);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Yeni kayıt ekleme
                    string insertQuery = @"INSERT INTO customer 
                (user_name, passwordd, phone, first_name, last_name)
                VALUES (@user_name, @passwordd, @phone, @first_name, @last_name)";

                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@user_name", userName);
                        insertCmd.Parameters.AddWithValue("@passwordd", password);
                        insertCmd.Parameters.AddWithValue("@phone", phone);
                        insertCmd.Parameters.AddWithValue("@first_name", firstName);
                        insertCmd.Parameters.AddWithValue("@last_name", lastName);

                        int result = insertCmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Formu kapatabilirsin istersen
                        }
                        else
                        {
                            MessageBox.Show("Kayıt işlemi başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}