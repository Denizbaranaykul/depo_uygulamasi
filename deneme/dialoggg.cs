using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace deneme
{
   
    public partial class dialoggg : DevExpress.XtraEditors.XtraForm
    {
        public dialoggg()
        {
            InitializeComponent();
        }
        public Image Picture
        {
            get => pictureEdit1.Image;
            set => pictureEdit1.Image = value;
        }

        // LabelControls

        public customer CustomerForm { get; set; }
        public string Label2Text
        {
            get => labelControl2.Text;
            set => labelControl2.Text = value;
        }

        public string Label3Text
        {
            get => lbl_ürün_isim.Text;
            set => lbl_ürün_isim.Text = value;
        }

        public string Richtextbox
        {
            get => labelControl4.Text;
            set => labelControl4.Text = value;
        }
        public string LabelText
        {
            get { return labelControl1.Text; }
            set { labelControl1.Text = value; }

        }

        public customer AnaForm { get; internal set; }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_sepete_ekle2_Click(object sender, EventArgs e)
        {
            Form1.customerForm.listBoxControl1.Items.Add(lbl_ürün_isim.Text);

            // Label'dan fiyatı al
            string order = labelControl2.Text;

            // "TL" kaldır, boşluk temizle, binlik ayraçları kaldır
            string fiyatMetni = order.Replace("TL", "").Trim().Replace(".", "");

            // Kültürü ayarla (ondalık için virgül desteklenmesi adına)
            var turkce = new CultureInfo("tr-TR");

            // Fiyatı ondalıklı olarak çöz
            if (decimal.TryParse(fiyatMetni, NumberStyles.Any, turkce, out decimal fiyat))
            {
                decimal mevcutTutar = 0;

                if (!string.IsNullOrEmpty(Form1.customerForm.lbl_order.Text))
                {
                    string mevcutMetin = Form1.customerForm.lbl_order.Text.Replace("TL", "").Trim().Replace(".", "");
                    decimal.TryParse(mevcutMetin, NumberStyles.Any, turkce, out mevcutTutar);
                }

                decimal yeniTutar = mevcutTutar + fiyat;

                // Sonucu göster: 2 ondalık, binlik ayraçlı
                Form1.customerForm.lbl_order.Text = yeniTutar.ToString("N2", turkce) + " TL";
            }
            else
            {
                MessageBox.Show("Fiyat formatı hatalı: " + labelControl2.Text, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 