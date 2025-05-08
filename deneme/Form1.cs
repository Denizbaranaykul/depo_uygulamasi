using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace deneme
{

    
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public MySqlConnection conn = new MySqlConnection("Server=localhost;Database=projem;Uid=root;Pwd=D3n!Z-25/11/2004?");
        public MySqlCommand cmd;
        public MySqlDataAdapter adapter;
        public DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }
        public static class GlobalDatabase
        {
            // Global olarak erişilebilen veritabanı bileşenleri
            public static MySqlConnection Conn { get; set; }
            public static MySqlCommand Cmd { get; set; }
            public static MySqlDataAdapter Adapter { get; set; }
            public static DataTable Dt { get; set; }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_form main=new main_form();
            main.StartPosition = FormStartPosition.CenterScreen;
            main.Show();
        }

        private void btn_login_customer_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM customer WHERE user_name=@user_name AND passwordd=@password";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@user_name", txt_user_name_customer.Text);
                cmd.Parameters.AddWithValue("@password", txt_password_customer.Text);
                adapter = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    GlobalDatabase.Conn = conn;
                    GlobalDatabase.Cmd = cmd;
                    GlobalDatabase.Adapter = adapter;
                    GlobalDatabase.Dt = dt;

                    customer customerForm = new customer();
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

    }
}
