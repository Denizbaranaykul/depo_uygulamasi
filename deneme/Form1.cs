using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace deneme
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public static MySqlConnection conn = new MySqlConnection("Server=localhost;Database=stok_takip;Uid=root;Pwd=12345");

        public class GLobalDatabase
        {
            public static MySqlCommand cmd;
            public static MySqlDataAdapter adapter;
            public static DataTable dt;
        }

        internal object listBoxControl1;
        public static customer customerForm= new customer();
        public static main_form main = new main_form();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = "SELECT * FROM admin WHERE user_name=@user_name AND passwordd=@passwordd";
                Form1.GLobalDatabase.cmd = new MySqlCommand(query, conn);

                Form1.GLobalDatabase.cmd.Parameters.Clear();
                Form1.GLobalDatabase.cmd.Parameters.AddWithValue("@user_name", txt_user_name.Text.Trim());
                Form1.GLobalDatabase.cmd.Parameters.AddWithValue("@passwordd", txt_password.Text.Trim());

                Form1.GLobalDatabase.adapter = new MySqlDataAdapter(Form1.GLobalDatabase.cmd);
                Form1.GLobalDatabase.dt = new DataTable();
                Form1.GLobalDatabase.adapter.Fill(Form1.GLobalDatabase.dt);
                
                if (Form1.GLobalDatabase.dt.Rows.Count > 0)
                {
                    main.Show();
                    this.Hide();
                  
                }
                else
                {
                    MessageBox.Show("Yönetici kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
               
                
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_login_customer_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = "SELECT * FROM customer WHERE user_name=@user_name AND passwordd=@passwordd";
                Form1.GLobalDatabase.cmd = new MySqlCommand(query, conn);

                Form1.GLobalDatabase.cmd.Parameters.Clear();
                Form1.GLobalDatabase.cmd.Parameters.AddWithValue("@user_name", txt_user_name_customer.Text.Trim());
                Form1.GLobalDatabase.cmd.Parameters.AddWithValue("@passwordd", txt_password_customer.Text.Trim());

                Form1.GLobalDatabase.adapter = new MySqlDataAdapter(Form1.GLobalDatabase.cmd);
                Form1.GLobalDatabase.dt = new DataTable();
                Form1.GLobalDatabase.adapter.Fill(Form1.GLobalDatabase.dt);

                if (Form1.GLobalDatabase.dt.Rows.Count > 0)
                {
                   
                    customerForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static implicit operator Form1(customer v)
        {
            throw new NotImplementedException();
        }

        private void btn_kayıt_ol_Click(object sender, EventArgs e)
        {
            kayıt_ol yeni_kayıt = new kayıt_ol();
            yeni_kayıt.Show();
        }

        private void btn_close_customer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
