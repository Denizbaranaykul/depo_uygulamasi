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


        public string Label2Text
        {
            get => labelControl2.Text;
            set => labelControl2.Text = value;
        }

        public string Label3Text
        {
            get => labelControl3.Text;
            set => labelControl3.Text = value;
        }

        // ListBoxControl
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
        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}