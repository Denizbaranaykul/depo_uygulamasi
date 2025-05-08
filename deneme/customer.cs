using DevExpress.CodeParser;
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
    public partial class customer : DevExpress.XtraEditors.XtraForm
    {
      
        public customer()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string name = "Iphone 14";
            string cost = "43.000 tl";
            string explation = "6.1 inç Super Retina XDR ekran\r\nTüm gün süren pil ömrü ve 20 saate kadar video oynatma\r\nCeramic Shield ve suya dayanıklılık\r\n5 çekirdekli GPU’ya sahip A15 Bionic çip ile ışık hızında performans\r\nHer ışıkta daha iyi fotoğraflar için gelişmiş kamera sistemi\r\nSorunsuz, titremeyen videolar çekmek için Hareket modu\r\nSaniyede 30 kareye kadar 4K Dolby Vision çekim yapan Sinematik mod\r\nSiz yardım çağıramadığınızda yardım çağıran önemli güvenlik özelliği Trafik Kazası Algılama\r\nKişiselleştirmenin, iletişim kurmanın ve paylaşmanın daha kolay yollarını sunan iOS 16";
            showdialog(name, cost, explation,Properties.Resources.iphone);
            
            
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

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string name = "Msi Gameing Laptop";
            string cost = "43.699 TL";
            string explation = "";
        }
    }
}