using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
} 