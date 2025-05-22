using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        static void data_pull()
        {
            string query= "SELECT * FROM urunler";
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string name = "Iphone 14";
            string cost = "43.000 TL";
            string explation = "6.1 inç Super Retina XDR ekran\r\nTüm gün süren pil ömrü ve 20 saate kadar video oynatma\r\nCeramic Shield ve suya dayanıklılık\r\n5 çekirdekli GPU’ya sahip A15 Bionic çip ile ışık hızında performans\r\nHer ışıkta daha iyi fotoğraflar için gelişmiş kamera sistemi\r\nSorunsuz, titremeyen videolar çekmek için Hareket modu\r\nSaniyede 30 kareye kadar 4K Dolby Vision çekim yapan Sinematik mod\r\nSiz yardım çağıramadığınızda yardım çağıran önemli güvenlik özelliği Trafik Kazası Algılama\r\nKişiselleştirmenin, iletişim kurmanın ve paylaşmanın daha kolay yollarını sunan iOS 16";
            showdialog(name, cost, explation,Properties.Resources.iphone);
        }
        
        private void ShowProductByName(string urunAdi)
        {
            
            string connectionString = "Server=localhost;Database=;Uid=root;Pwd=12345";
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

                            byte[] imageBytes = (byte[])reader["foto"];
                            Image art = null;

                            if (imageBytes != null && imageBytes.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    art = Image.FromStream(ms);
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

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string name = "Msi Gameing Laptop";
            string cost = "43.699 TL";
            string explation = "İşlemci (CPU): Intel Core i7 / i9 (13. veya 14. Nesil)\r\n– veya AMD Ryzen 7 / 9 serisi\r\n\r\nGrafik Kartı (GPU): NVIDIA GeForce RTX 4060 / 4070 / 4080 / 4090 (Laptop GPU)\r\n\r\nRAM: 16 GB – 64 GB DDR5 (genellikle 2 slot, yükseltilebilir)\r\n\r\nDepolama: 512 GB – 2 TB NVMe SSD\r\n\r\n💻 Ekran Özellikleri\r\nEkran Boyutu: 15.6 inç veya 17.3 inç\r\n\r\nÇözünürlük: Full HD (1920×1080) – QHD (2560×1440) – bazen 4K\r\n\r\nYenileme Hızı: 144 Hz – 240 Hz – 360 Hz (oyuncular için yüksek hız)\r\n\r\nPanel Türü: IPS (geniş görüş açısı)\r\n\r\n🔊 Ses ve Multimedya\r\nNahimic 3 ses desteği\r\n\r\n2x stereo hoparlör\r\n\r\nMikrofon ve kulaklık jakı (ayrı veya birleşik)\r\n\r\n📶 Bağlantı Özellikleri\r\nWi-Fi 6 / 6E\r\n\r\nBluetooth 5.2\r\n\r\nUSB: 2–3 adet USB-A, 1–2 adet USB-C (bazı modellerde Thunderbolt 4)\r\n\r\nHDMI: Var (4K çıkış destekli)\r\n\r\nEthernet: RJ-45 LAN girişi mevcut (gigabit)\r\n\r\nSD Kart Girişi: Genelde yok (modeline bağlı)\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nMalzeme: Metal + sert plastik kasa\r\n\r\nAğırlık: 2.2 – 2.8 kg (modeline göre)\r\n\r\nKalınlık: 20 – 27 mm\r\n\r\nKlavye: SteelSeries RGB aydınlatmalı (tek bölge ya da her tuş ayrı RGB olabilir)\r\n\r\nSoğutma: Cooler Boost teknolojisi (çift fanlı – çoklu ısı borulu sistem)\r\n\r\n🔋 Batarya ve Güç\r\nBatarya Kapasitesi: 53 Wh – 99 Wh\r\n\r\nAdaptör: Yüksek watt’lı (180W – 330W arası, modele göre)\r\n\r\n\U0001f9e0 Yazılım Özellikleri\r\nMSI Center (performans ayarı, fan kontrolü, oyun modu)\r\n\r\nNahimic ses uygulaması\r\n\r\nMystic Light (RGB ayarları, varsa)\r\n\r\n";
            showdialog(name, cost, explation, Properties.Resources.laptop);
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            string name = "ofis masası";
            string cost = "10.000 TL";
            string explation = "";
            showdialog(name, cost, explation, Properties.Resources.ofis_masa);
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            string name = "şampuan";
            string cost = "200 TL";
            string explation = "\U0001f9f4 Temel Özellikler\r\nÜrün Adı: Head & Shoulders Şampuan\r\n\r\nTanım: Kepeğe karşı etkili, saç ve saç derisini temizleyip ferahlatan bakım şampuanı\r\n\r\nKullanım Alanı: Günlük saç temizliği ve kepek önleyici bakım\r\n\r\n\U0001f9ea İçerik Özellikleri\r\nEtken Madde:\r\n\r\nZinc Pyrithione (kepeği azaltmaya yardımcı olur)\r\n\r\nDiğer İçerikler:\r\n\r\nNemlendirici ajanlar\r\n\r\nBitki özleri (bazı serilerde: mentol, elma, lavanta vs.)\r\n\r\nParfüm (ferah koku)\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nForm: Jel/krem kıvamında sıvı şampuan\r\n\r\nŞişe Boyutları: 180 ml, 400 ml, 600 ml ve 1000 ml gibi farklı seçenekler\r\n\r\nKullanım Şekli: Islak saça uygulanır, köpürtülür ve durulanır\r\n\r\n💇‍♂️ Fonksiyonel Özellikler\r\nBaşlıca Etkileri:\r\n\r\nKepeği azaltır ve yeniden oluşumunu önlemeye yardımcı olur\r\n\r\nSaç derisini rahatlatır\r\n\r\nSaçı temizler ve ferahlatır\r\n\r\nGünlük kullanıma uygundur\r\n\r\nSeri Seçenekleri:\r\n\r\nClassic Clean\r\n\r\nMenthol Ferahlığı\r\n\r\nDerin Temizlik\r\n\r\n2'si 1 Arada (şampuan + saç kremi)\r\n\r\nHassas saç derisi için özel formüller\r\n\r\n\U0001f9fc Kullanım ve Temizlik\r\nSaçtan kolayca durulanır\r\n\r\nHer saç tipiyle uyumlu varyantlar mevcuttur (kuru, yağlı, ince telli, boyalı)\r\n\r\n🎨 Tasarım\r\nBeyaz-mavi tonlarında, pratik kapaklı plastik şişe\r\n\r\nErgonomik tasarım, duşta kolay kullanım için el şekline uygun\r\n\r\n";
            showdialog(name, cost, explation, Properties.Resources.sampuan);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string name = "iPad Air M3";
            string cost = "27.000 TL";
            string explation = "İşlemci: Apple M3 çip (8 çekirdekli CPU, 10 çekirdekli GPU)\r\n\r\nEkran Boyutu:\r\n\r\n11 inç veya 13 inç Liquid Retina (LCD)\r\n\r\nTrue Tone, P3 geniş renk gamı, 500 nit parlaklık\r\n\r\nDepolama Seçenekleri: 128 GB, 256 GB, 512 GB, 1 TB\r\n\r\nRAM: Tahmini 8 GB (Apple resmi olarak belirtmiyor)\r\n\r\nKamera (Arka): 12 MP geniş kamera\r\n\r\nKamera (Ön): 12 MP ultra geniş ön kamera (yatay konumda)\r\n\r\n🔋 Batarya ve Şarj\r\nPil Ömrü: 10 saate kadar web, video izleme (Wi-Fi)\r\n\r\nBağlantı Noktası: USB-C (Thunderbolt yok)\r\n\r\n📶 Bağlantı Özellikleri\r\nWi-Fi 6E, Bluetooth 5.3\r\n\r\n5G destekli model (opsiyonel hücresel)\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nKalınlık: 6.1 mm\r\n\r\nAğırlık:\r\n\r\n11 inç: ~462 gram (Wi-Fi)\r\n\r\n13 inç: ~617 gram (Wi-Fi)\r\n\r\nMalzeme: Geri dönüştürülmüş alüminyum kasa\r\n\r\nRenkler: Uzay Grisi, Yıldız Işığı, Mor, Mavi\r\n\r\n🖊️ Apple Pencil ve Klavye Desteği\r\nApple Pencil Pro ve Pencil (USB-C) desteği\r\n\r\nMagic Keyboard (iPad Pro 11 inç modeliyle uyumlu)";
            showdialog(name, cost, explation, Properties.Resources.tablet);
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            string name = "playstation 5";
            string cost = "38.000 TL";
            string explation = "/*İşlemci (CPU): 8 çekirdekli AMD Zen 2 (3.5 GHz)\r\n\r\nGrafik İşlemci(GPU): AMD RDNA 2 – 10.28 TFLOPS\r\n\r\nRAM: 16 GB GDDR6\r\n\r\nDepolama: 825 GB SSD(yüksek hızlı, özel tasarım)\r\n\r\nGenişletilebilir M.2 SSD yuvası mevcut\r\n\r\n🎮 Oyun ve Görsel Performans\r\nÇözünürlük: 4K 60 FPS (bazı oyunlarda 120 FPS'e kadar)\r\n\r\n8K desteği: Var(uyumlu içeriklerde)\r\n\r\nRay Tracing: Var\r\n\r\nHDR: Var\r\n\r\n📀 Disk ve Dijital Sürümler\r\nStandart PS5: Ultra HD Blu-ray Disk Sürücüsü\r\n\r\nPS5 Digital Edition: Disk sürücüsü yok (sadece dijital içerik)\r\n\r\n📶 Bağlantı ve Diğer Özellikler\r\nWi-Fi 6, Bluetooth 5.1\r\n\r\nUSB Bağlantılar:\r\n\r\n2× USB 3.1 Type-A\r\n\r\n1× USB Type-C\r\n\r\nEthernet girişi\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nBoyutlar:\r\n\r\nStandart PS5: Yaklaşık 390 x 104 x 260 mm\r\n\r\nAğırlık:\r\n\r\nStandart PS5: ~4.5 kg\r\n\r\nDigital Edition: ~3.9 kg\r\n\r\nSoğutma: Büyük fan + sıvı metal termal iletken (sessiz ve güçlü soğutma)\r\n\r\nRenk: Beyaz - siyah gövde(özel kapak seçenekleriyle değiştirilebilir)\r\n\r\n🎮 DualSense Kontrol Cihazı\r\nDokunsal geri bildirim (haptic feedback)\r\n\r\nUyarlanabilir tetikler (adaptive triggers)\r\n\r\nDahili mikrofon ve hoparlör\r\n\r\n*/";
            showdialog(name, cost, explation, Properties.Resources.playstatıon);
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            string name = "xbox one s";
            string cost = "32.000 TL";
            string explation = "İşlemci (CPU): 8 çekirdekli AMD Jaguar, 1.75 GHz\r\n\r\nGrafik İşlemci (GPU): AMD GCN – 1.31 TFLOPS\r\n\r\nRAM: 8 GB DDR3\r\n\r\nDepolama: 500 GB veya 1 TB HDD (mekanik disk)\r\n\r\nHarici USB 3.0 disk desteği mevcut\r\n\r\n🎮 Oyun ve Görsel Performans\r\nÇözünürlük: 900p – 1080p (çoğu oyunda)\r\n\r\nFPS: Genellikle 30–60 FPS\r\n\r\nHDR: Yalnızca Xbox One S ve X modellerinde\r\n\r\nDisk Sürücüsü: Blu-ray/DVD sürücüsü\r\n\r\n📶 Bağlantı Özellikleri\r\nWi-Fi: Wi-Fi 802.11n (Wi-Fi 5)\r\n\r\nBluetooth: Yok (kulaklıklar için değil, sadece kontrolcü bağlamak için özel RF bağlantı)\r\n\r\nUSB: 3× USB 3.0 portu\r\n\r\nHDMI:\r\n\r\nHDMI çıkış (TV için)\r\n\r\nHDMI giriş (TV alıcısı vb. bağlamak için)\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nBoyutlar (Xbox One orijinal): Yaklaşık 333 x 274 x 79 mm\r\n\r\nAğırlık: ~3.5 kg\r\n\r\nMalzeme: Mat ve parlak plastik karışımı kasa\r\n\r\nSoğutma: Fanlı hava soğutma (üstten havalandırmalı)\r\n\r\nHarici Güç Adaptörü: Mevcut (özellikle orijinal Xbox One’da)\r\n\r\n🎮 Kontrol Cihazı\r\nXbox One kablosuz kontrolcü\r\n\r\nTitreşimli tetikler\r\n\r\n3.5 mm kulaklık girişi (sonraki versiyonlarda)\r\n\r\nAA pil veya şarjlı kit ile çalışır\r\n\r\n🔄 Geriye Uyumluluk\r\nXbox 360 ve bazı orijinal Xbox oyunlarını çalıştırabilir (dijital olarak)";
            showdialog(name, cost, explation, Properties.Resources.xbox);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            string name = "playstation 5 kolu";
            string cost = "1.500 TL";
            string explation = "🎮 Temel Özellikler\r\nModel Adı: DualSense Wireless Controller\r\n\r\nUyumluluk: PS5, bazı PC oyunları, Android/iOS (sınırlı destek)\r\n\r\nBağlantı: Bluetooth 5.1 ve USB-C kablolu bağlantı\r\n\r\n\U0001f9e0 Teknolojik Özellikler\r\nDokunsal Geri Bildirim (Haptic Feedback):\r\n\r\nTitreşim yerine gelişmiş, hassas titreşim motorları\r\n\r\nOyundaki yüzey hissiyatı (kum, buz, metal vs.) gerçekçi iletilir\r\n\r\nUyarlanabilir Tetikler (Adaptive Triggers):\r\n\r\nL2 ve R2 tuşları, farklı sertlik seviyelerinde direnç uygular\r\n\r\nÖrnek: Ok germe, silah sıkışması gibi etkiler\r\n\r\n🔊 Ekstra Özellikler\r\nDahili Mikrofon: Sohbet için mikrofon var (kapatılabilir)\r\n\r\nHoparlör: Oyundaki bazı sesler doğrudan koldan gelir\r\n\r\nKulaklık Girişi: 3.5 mm jak ile kulaklık takılabilir\r\n\r\nMotion Sensor (Hareket Sensörü): 6 eksenli jiroskop ve ivmeölçer\r\n\r\n🔋 Batarya ve Şarj\r\nBatarya Türü: Dahili şarj edilebilir lityum-ion\r\n\r\nŞarj Girişi: USB-C\r\n\r\nPil Ömrü: Ortalama 6–12 saat (kullanıma göre değişir)\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nBoyut: Yaklaşık 160 x 66 x 106 mm\r\n\r\nAğırlık: ~280 gram\r\n\r\nMalzeme: Mat plastik, kaymaz yüzeyli tetikler\r\n\r\nRenk Seçenekleri: Beyaz (standart), ayrıca siyah, kırmızı, mavi, mor, özel desenli sürümler\r\n\r\n🌈 Işıklandırma\r\nTouchpad çevresinde LED ışık çerçevesi\r\n\r\nOyun durumuna göre renk değiştirebilir (örneğin sağlık durumu)\r\n\r\n";
            showdialog(name, cost, explation, Properties.Resources.oyunkolu);
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            string name = "ispanyol paça pantolon";
            string cost = "600 TL";
            string explation = "👖 Temel Özellikler\r\nModel Adı: İspanyol Paça (Flare) Pantolon\r\n\r\nTanım: Dizden itibaren genişleyerek inen pantolon modeli\r\n\r\nKullanım Alanı: Günlük giyim, şık kombinler, retro/vintage tarzlar\r\n\r\n\U0001f9f5 Kumaş Özellikleri\r\nKumaş Türü: Kot (denim), viskon, polyester, gabardin, kadife, likralı kumaşlar\r\n\r\nEsneklik: Genellikle hafif esnek (stretch) modeller tercih edilir\r\n\r\nAğırlık: Kumaşa göre değişir (jean türleri daha ağır)\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nBel Yüksekliği: Yüksek bel (yaygın), orta bel veya düşük bel seçenekli\r\n\r\nKesim:\r\n\r\nÜst bacak kısmı dar\r\n\r\nDizden sonra genişleyen paça\r\n\r\nPaça Genişliği: Ortalama 25–30 cm (tek paça için)\r\n\r\nBoy Uzunluğu: Genellikle topuk hizasında veya yere kadar uzun\r\n\r\n\U0001faa1 Tasarım ve Dikiş Detayları\r\nFermuarlı veya düğmeli kapama\r\n\r\nCepli ya da cepsiz tasarım\r\n\r\nBazı modellerde pile, dikiş detayları veya kemer halkaları bulunabilir\r\n\r\n🎨 Renk ve Stil Seçenekleri\r\nRenkler: Kot mavisi, siyah, beyaz, krem, bej, pastel tonlar, desenli modeller\r\n\r\nStil: Günlük, bohem, retro, ofis tarzı veya gece şıklığına uygun\r\n\r\n👟 Uyumlu Parçalar\r\nÜst: Kısa üstler (crop top), gömlek, blazer ceket\r\n\r\nAlt: Topuklu ayakkabı, bot veya platform sneaker\r\n\r\n";
            showdialog(name, cost, explation, Properties.Resources.kadın_pantolon);
        }

        private void simpleButton28_Click(object sender, EventArgs e)
        {
            string name = "çocuk elbise";
            string cost = "800 TL";
            string explation = "👗 Temel Özellikler\r\nModel Adı: Kız Çocuk Kırmızı Elbise\r\n\r\nTanım: Canlı kırmızı renkte, çocuklar için rahat ve şık elbise\r\n\r\nKullanım Alanı: Günlük kullanım, özel günler, doğum günü, okul etkinlikleri\r\n\r\n\U0001f9f5 Kumaş Özellikleri\r\nKumaş Türü:\r\n\r\nPamuklu (nefes alabilir ve yumuşak)\r\n\r\nPolyester karışımlı (dayanıklı ve kolay temizlenen)\r\n\r\nFırfırlı veya tüllü detaylı modeller olabilir\r\n\r\nEsneklik: Orta derecede esnek, hareket özgürlüğü sağlar\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nKesim Tipleri:\r\n\r\nA-kesim (belden hafif genişleyen)\r\n\r\nDüz kesim\r\n\r\nFırfırlı, pileli veya kat kat modeller\r\n\r\nBoy Uzunluğu: Mini (diz üstü) veya midi (diz altı)\r\n\r\nKol Tipi: Kısa kol, uzun kol, askılı veya fırfırlı kol seçenekleri\r\n\r\nKapatma: Arkada düğme, fermuar veya üstten çıtçıt\r\n\r\n🎨 Renk ve Stil\r\nRenk: Canlı kırmızı, kırmızı tonları (parlak veya mat)\r\n\r\nStil: Eğlenceli, şık, çocuk dostu tasarım\r\n\r\n👟 Uyumlu Kombinler\r\nAyakkabı: Babet, sandalet veya spor ayakkabı\r\n\r\nAksesuar: Saç bantları, toka, küçük çantalar\r\n\r\nÜst: İnce hırka veya ceket (soğuk havalar için)\r\n\r\n";
            showdialog(name, cost, explation, Properties.Resources.kız_cocuk_elbıse);
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            string name = "kumaş pantolon";
            string cost = "900 TL";
            string explation = "👖 Temel Özellikler\r\nModel Adı: antrasit Rengi Kumaş Pantolon\r\n\r\nTanım: Şık ve sade görünüm sunan,\r\n\r\nKullanım Alanı: Ofis, günlük, özel gün, yazlık kombinler\r\n\r\n\U0001f9f5 Kumaş Özellikleri\r\nKumaş Türü: Pamuk, polyester, viskon, keten, yün karışımları\r\n\r\nAstarlama: Açık renk olduğu için bazı modellerde iç göstermezlik için astar bulunur\r\n\r\nEsneklik: Az esnek veya orta esneklik (likralı modeller de mevcut)\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nBel Yüksekliği: Yüksek bel, orta bel (modeller arasında değişir)\r\n\r\nKesim:\r\n\r\nSlim fit (dar kesim)\r\n\r\nStraight (düz kesim)\r\n\r\nWide leg (bol paça) gibi seçenekler bulunur\r\n\r\nPaça Tipi: Genellikle klasik düz paça ya da ütü çizgili\r\n\r\nBoy Uzunluğu: Bilek boyu, tam boy veya yüksek topukla uyumlu uzunluklar\r\n\r\n\U0001faa1 Tasarım ve Dikiş Detayları\r\nFermuar + düğme kapama (klasik)\r\n\r\nYan cepler ve arka cep detayları\r\n\r\nBeli kemerli ya da kemer halkalı olabilir\r\n\r\nÜtü çizgili modellerde daha resmi duruş\r\n\r\n";
            showdialog(name, cost, explation, Properties.Resources.pontolon);
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            string name = "spor ayakkabı";
            string cost = "800 TL";
            string explation = "👟 Temel Özellikler\r\nModel Adı: Spor Ayakkabı (Sneaker / Trainer)\r\n\r\nTanım: Günlük veya sportif aktiviteler için tasarlanmış rahat ayakkabı türü\r\n\r\nKullanım Alanı: Günlük kullanım, yürüyüş, koşu, spor salonu, kombin tamamlayıcı\r\n\r\n\U0001f9f5 Malzeme Özellikleri\r\nÜst Yüzey (Saya):\r\n\r\nFile (nefes alabilir)\r\n\r\nDeri (doğal veya suni)\r\n\r\nNubuk veya kumaş karışımı\r\n\r\nİç Astar: Ter emici kumaş, yumuşak dolgu\r\n\r\nTaban Malzemesi:\r\n\r\nEVA (hafif ve esnek sünger)\r\n\r\nKauçuk (kaymaz ve dayanıklı)\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nBağlama Tipi: Bağcıklı (yaygın), cırt cırtlı (özellikle çocuk modelleri) veya slip-on\r\n\r\nAğırlık: Hafif – orta ağırlıkta (modeline göre 250–450 gram arası)\r\n\r\nTopuk: Genellikle düz veya yumuşak dolgulu (şok emici)\r\n\r\nTaban Yüksekliği: 2 – 5 cm arası değişebilir\r\n\r\n";
            showdialog(name, cost, explation, Properties.Resources.ayakkabı);
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            string name = "gömlek";
            string cost = "600 TL";
            string explation = "👔 Temel Özellikler\r\nModel Adı: Bej Gömlek\r\n\r\nTanım: Açık toprak tonlarında, sade ve nötr renkte, çok yönlü kullanılabilen gömlek\r\n\r\nKullanım Alanı: Günlük, ofis, smart casual, yazlık kombinler\r\n\r\n\U0001f9f5 Kumaş Özellikleri\r\nKumaş Türü:\r\n\r\nPamuk (nefes alır, doğal)\r\n\r\nKeten (yazlık, hafif)\r\n\r\nViskon (dökümlü ve yumuşak)\r\n\r\nPoplin, gabardin, ipek (daha şık seçenekler)\r\n\r\nEsneklik: Genellikle esnemez, bazı modellerde elastan katkılı\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nKesim Tipi:\r\n\r\nRegular fit (klasik)\r\n\r\nSlim fit (vücuda oturan)\r\n\r\nOversize (bol ve rahat)";
            showdialog(name, cost, explation, Properties.Resources.gömlek);
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            string name = "converse ayakkabı";
            string cost = "1000 TL";
            string explation = "👟 Temel Özellikler\r\nModel Adı: Converse Chuck Taylor All Star (Siyah – klasik model)\r\n\r\nTanım: Klasik, bağcıklı, düz tabanlı ve siyah renkli ikonik sneaker\r\n\r\nKullanım Alanı: Günlük giyim, sokak stili, casual kombinler\r\n\r\n\U0001f9f5 Malzeme Özellikleri\r\nÜst Yüzey (Saya):\r\n\r\nSiyah kanvas kumaş (dayanıklı pamuklu dokuma)\r\n\r\nBazı modellerde deri versiyon da mevcut\r\n\r\nİç Astar: İnce tekstil astar (pamuklu veya sentetik)\r\n\r\nBurun Kısmı: Kauçuk burun (beyaz, klasik Converse stili)\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nBağlama: Klasik bağcıklı sistem (beyaz veya siyah bağcıklar)\r\n\r\nTopuk Yüksekliği: Düz – 2 cm civarı taban\r\n\r\nTaban Malzemesi: Kalın kauçuk (kaymaz, esnek)\r\n\r\nAğırlık: Hafif – orta ağırlıkta (~350–450 gram/çift)\r\n\r\nKesim Tipi:\r\n\r\nLow-top: Bilek altı (klasik)\r\n\r\nHigh-top: Bilek üstü (daha ikonik görünüm)\r\n\r\n🎨 Renk ve Stil\r\nRenk: Siyah dış yüzey + beyaz burun + beyaz taban\r\n\r\nLogo: Yan kısımda \"Converse All Star\" etiketi\r\n\r\nStil: Retro, sokak modası, unisex\r\n\r\n👖 Uyumlu Kombinler\r\nJean, şort, chino, eşofman, eteklerle uyumlu\r\n\r\nSpor-şık ve salaş kombinlerde sık kullanılır\r\n\r\n";
            showdialog(name, cost, explation, Properties.Resources.converse);
        }

        private void simpleButton27_Click(object sender, EventArgs e)
        {
            string name = "elbise";
            string cost = "1000 TL";
            string explation = "👗 Temel Özellikler\r\nModel Adı: Kırmızı Elbise\r\n\r\nTanım: Canlı kırmızı tonlarında, farklı kesim ve tarzlarda kadın elbisesi\r\n\r\nKullanım Alanı: Özel davetler, gece partileri, günlük şıklık, resmi organizasyonlar\r\n\r\n\U0001f9f5 Kumaş Özellikleri\r\nKumaş Türü:\r\n\r\nSaten, şifon, kadife, pamuklu kumaş, viskon, polyester\r\n\r\nBazı modellerde dantel veya tül detayları\r\n\r\nEsneklik: Model ve kumaşa göre değişir; elastan katkılı esnek modeller olabilir\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nKesim Tipleri:\r\n\r\nA-kesim (belden genişleyen)\r\n\r\nKalem kesim (dar, vücuda oturan)\r\n\r\nMaxi, midi veya mini boy\r\n\r\nAskılı, uzun kollu, kolsuz veya omuz detaylı modeller\r\n\r\nBoy Uzunluğu: Mini (diz üstü), midi (diz altı) veya maxi (yer uzunluğu)\r\n\r\nDetaylar: Düğme, fermuar, kuşak, fırfır gibi süslemeler olabilir\r\n\r\n🎨 Renk ve Stil\r\nRenk: Canlı kırmızı, bordo tonları, açık kırmızı\r\n\r\nStil:\r\n\r\nGünlük şıklık\r\n\r\nGece elbisesi\r\n\r\nOfis şıklığı (daha kapalı ve klasik modeller)\r\n\r\n👠 Uyumlu Kombinler\r\nAyakkabı: Topuklu ayakkabı, sandalet, babet\r\n\r\nAksesuar: Altın veya gümüş takılar, şık çanta\r\n\r\nÜst: Blazer ceket, şal, kürk detaylı kaban (soğuk havalar için)";
            showdialog(name, cost, explation, Properties.Resources.elbise_kırmızı);
        }

        private void simpleButton26_Click(object sender, EventArgs e)
        {
            string name = "elbise";
            string cost = "1200 TL";
            string explation = "👗 Temel Özellikler\r\nModel Adı: Mavi Elbise\r\n\r\nTanım: Çeşitli tonlarda mavi renkte, farklı kesim ve tarzlarda kadın elbisesi\r\n\r\nKullanım Alanı: Günlük, iş, özel davetler, gece partileri, yazlık kombinler\r\n\r\n\U0001f9f5 Kumaş Özellikleri\r\nKumaş Türü:\r\n\r\nPamuk, viskon, şifon, saten, polyester, denim\r\n\r\nBazı modellerde dantel veya tül detayları bulunabilir\r\n\r\nEsneklik: Kumaşa göre değişir; elastan katkılı modeller esnek olabilir\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nKesim Tipleri:\r\n\r\nA-kesim (belden genişleyen)\r\n\r\nKalem kesim (dar, vücuda oturan)\r\n\r\nMaxi, midi veya mini boy\r\n\r\nAskılı, uzun kollu, kısa kollu, kolsuz veya omuz detaylı modeller\r\n\r\nBoy Uzunluğu: Mini (diz üstü), midi (diz altı) veya maxi (yer uzunluğu)\r\n\r\nDetaylar: Fermuar, düğme, kuşak, fırfır, pile gibi süslemeler olabilir\r\n\r\n🎨 Renk ve Stil\r\nRenk: Açık mavi, lacivert, pastel mavi, elektrik mavisi gibi tonlar\r\n\r\nStil:\r\n\r\nGünlük ve rahat\r\n\r\nOfis şıklığı\r\n\r\nGece ve davet elbisesi\r\n\r\n👠 Uyumlu Kombinler\r\nAyakkabı: Topuklu ayakkabı, babet, sandalet, sneaker\r\n\r\nAksesuar: Gümüş, inci takılar, şık çanta\r\n\r\nÜst: Ceket, hırka, blazer ceket (mevsime göre)\r\n\r\n";
            showdialog(name, cost, explation, Properties.Resources.ebıse_mavi);
        }

        private void simpleButton29_Click(object sender, EventArgs e)
        {
            string name = "topuklu ayakkabı";
            string cost = "700 TL";
            string explation = "👠 Temel Özellikler\r\nModel Adı: Topuklu Siyah Ayakkabı\r\n\r\nTanım: Siyah renkli, topuklu, kadın ayakkabısı\r\n\r\nKullanım Alanı: Resmi davetler, iş toplantıları, gece çıkışları, özel günler\r\n\r\n\U0001f9f5 Malzeme Özellikleri\r\nDış Malzeme:\r\n\r\nDeri (gerçek veya suni)\r\n\r\nSüet, saten veya kumaş\r\n\r\nİç Astar: Yumuşak deri veya tekstil astar, konfor için dolgu\r\n\r\nTaban: Kaymaz kauçuk veya deri taban\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nTopuk Yüksekliği:\r\n\r\nDüşük topuk (3-5 cm)\r\n\r\nOrta topuk (5-8 cm)\r\n\r\nYüksek topuk (8 cm ve üzeri)\r\n\r\nTopuk Tipi: İnce (stiletto), kalın (blok topuk), küt, konik\r\n\r\nBurun Şekli: Sivri, yuvarlak, kare burun modelleri\r\n\r\nBağlama: Bağcıklı, tokalı veya slip-on (kaydırmalı)\r\n\r\n🎨 Renk ve Stil\r\nRenk: Mat veya parlak siyah\r\n\r\nStil: Klasik, modern, şık, minimal veya gösterişli modeller\r\n\r\n👗 Uyumlu Kombinler\r\nElbise, etek, pantolon takımı, hatta şık jeanlerle kombinlenebilir\r\n\r\nÇanta ve takılarla uyumlu, genellikle siyah veya metalik renkler tercih edilir\r\n\r\n☁️ Konfor ve Ekstra Özellikler\r\nYastıklı iç taban ile konfor artırılabilir\r\n\r\nTopuk yüksekliğine göre denge ve yürüyüş kolaylığı değişir\r\n\r\nBazı modellerde platform taban veya dolgulu topuklar bulunabilir";
            showdialog(name, cost, explation, Properties.Resources.topuklu);
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            string name = "6 lı çorap";
            string cost = "150 TL";
            string explation = "Temel Özellikler\r\nModel Adı: Çorap\r\n\r\nTanım: Ayakları sararak koruyan, farklı uzunluk ve kalınlıkta giysi parçası\r\n\r\nKullanım Alanı: Günlük kullanım, spor, iş, özel durumlar\r\n\r\n\U0001f9f5 Malzeme Özellikleri\r\nKumaş Türü:\r\n\r\nPamuk (nefes alır, yumuşak)\r\n\r\nPolyester, naylon, elastan (esneklik ve dayanıklılık için)\r\n\r\nYün (soğuk havalar için sıcak tutar)\r\n\r\nEsneklik: Elastan veya likra katkılı, ayağa oturur\r\n\r\n";
            showdialog(name, cost, explation, Properties.Resources.çorap);
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            string name = "mutfak masası";
            string cost = "8.000 TL";
            string explation = "🍽️ Temel Özellikler\r\nModel Adı: Mutfak Masası\r\n\r\nTanım: Yemek yeme, hazırlık yapma veya günlük kullanım için mutfakta yer alan masa\r\n\r\nKullanım Alanı: Mutfak, yemek alanı, küçük oturma alanları\r\n\r\n\U0001fab5 Malzeme Özellikleri\r\nTabla (Üst Yüzey):\r\n\r\nAhşap (masif, MDF, suntalam)\r\n\r\nCam (şeffaf veya desenli)\r\n\r\nMermer veya mermer görünümlü yüzey\r\n\r\nAyak Malzemesi:\r\n\r\nAhşap, metal veya plastik\r\n\r\nBazı modellerde katlanabilir veya tekerlekli\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nBoyutlar:\r\n\r\n2, 4, 6 kişilik modeller yaygındır\r\n\r\nGenişlik: 70–100 cm\r\n\r\nUzunluk: 100–180 cm\r\n\r\nYükseklik: Genellikle 75 cm civarı\r\n\r\nFonksiyonlar:\r\n\r\nAçılır-kapanır sistemli\r\n\r\nKatlanabilir masa kanatları\r\n\r\nSandalye içine giren kompakt modeller\r\n\r\n🎨 Stil ve Tasarım\r\nTasarım Tarzı:\r\n\r\nModern (düz, sade hatlar)\r\n\r\nKlasik (oymalı, detaylı)\r\n\r\nCountry / rustik (doğal ahşap görünüm)\r\n\r\nMinimal (küçük ve fonksiyonel)\r\n\r\nRenk: Beyaz, meşe, ceviz, siyah, gri gibi çok sayıda seçenek\r\n\r\n\U0001f9f0 Kullanım ve Dayanıklılık\r\nSık temizlik ve kullanıma uygun sağlam yüzey\r\n\r\nLeke ve ısıya dayanıklı malzeme tercih edilir\r\n\r\nKüçük mutfaklar için yer tasarrufu sağlayan modeller öne çıkar";
            showdialog(name, cost, explation, Properties.Resources.playstatıon);
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            string name = "oturma grubu";
            string cost = "35.000 TL";
            string explation = "🛋️ Temel Özellikler\r\nTanım: Ev veya ofislerde oturma amaçlı kullanılan, genellikle koltuk, kanepe ve berjer gibi parçalardan oluşan mobilya takımı\r\n\r\nKullanım Alanı: Oturma odası, salon, bekleme alanları, çalışma ofisleri\r\n\r\n\U0001f9f0 Yapısal Özellikler\r\nParçalar:\r\n\r\nKanepe (2 veya 3 kişilik)\r\n\r\nTekli koltuk (berjer)\r\n\r\nOturma pufları veya tabureler\r\n\r\nSehpa (bazı takımlarda dahil)\r\n\r\nİskelet: Ahşap veya metal çerçeve\r\n\r\nDolgu Malzemesi: Sünger, visko elastik köpük, elyaf dolgulu\r\n\r\n\U0001f9f5 Kumaş ve Döşeme\r\nKumaş Türü:\r\n\r\nKadife, mikrofiber, deri, suni deri, keten, pamuklu kumaş\r\n\r\nRenk: Çok çeşitli, genellikle ev dekorasyonuna uygun tonlarda\r\n\r\nBakım: Kolay temizlenebilir ve dayanıklı kumaşlar tercih edilir\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nBoyutlar: Takımın toplam genişliği, derinliği ve yüksekliği değişken\r\n\r\nOturma Derinliği ve Yüksekliği: Konfor için ideal ergonomik ölçülerde tasarlanır\r\n\r\nAyak Malzemesi: Ahşap, metal veya plastik olabilir\r\n\r\nFonksiyonellik: Bazı modellerde yatak olabilme, depolama alanı, ayarlanabilir sırt veya kol kısımları\r\n\r\n🎨 Stil ve Tasarım\r\nModern, klasik, rustik, minimal, vintage gibi farklı tasarım seçenekleri\r\n\r\nRenk ve desen uyumu, evin genel dekorasyonuna göre seçilir\r\n\r\n🏡 Kullanım ve Konfor\r\nGünlük dinlenme, misafir ağırlama, televizyon izleme gibi aktiviteler için konforlu oturma sağlar\r\n\r\nYumuşak dolgular ve ergonomik tasarım uzun süreli kullanımda rahatlık sunar";
            showdialog(name, cost, explation, Properties.Resources.images);
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            string name = "gardırop";
            string cost = "12.000 TL";
            string explation = "";
            showdialog(name, cost, explation, Properties.Resources.gardırop);
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            string name = "parfüm";
            string cost = "200 TL";
            string explation = "🌸 Temel Özellikler\r\nÜrün Adı: Parfüm\r\n\r\nTanım: Cilde veya giysilere uygulanan, hoş koku yayan sıvı karışım\r\n\r\nKullanım Alanı: Kişisel bakım, günlük kullanım, özel davetler\r\n\r\n\U0001f9ea İçerik Özellikleri\r\nTemel Bileşenler:\r\n\r\nEsans yağları (çiçek, meyve, odunsu, baharatlı vs.)\r\n\r\nAlkol (çözücü)\r\n\r\nSu (seyreltici)\r\n\r\nKoku Notaları:\r\n\r\nÜst Nota: İlk duyulan taze kokular (narenciye, meyve)\r\n\r\nOrta Nota: Kalp notaları (çiçeksi, baharatlı)\r\n\r\nAlt Nota: Kalıcı, derin kokular (amber, misk, odunsu)\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nFormu:\r\n\r\nSpreyli şişe, roll-on, katı parfüm\r\n\r\nYoğunluk Türleri:\r\n\r\nParfum (Extrait): %20-30 esans — çok kalıcı\r\n\r\nEau de Parfum (EDP): %15-20 — uzun süreli\r\n\r\nEau de Toilette (EDT): %5-15 — orta kalıcılık\r\n\r\nEau de Cologne (EDC): %2-5 — hafif ve taze\r\n\r\nŞişe Boyutu: 30 ml, 50 ml, 100 ml gibi seçenekler\r\n\r\n🎨 Tasarım ve Stil\r\nŞişe tasarımları marka ve tarzla uyumludur (minimal, lüks, klasik)\r\n\r\nRenkli cam, opak şişe veya dekoratif kapak detayları olabilir\r\n\r\n\U0001f9f4 Kullanım ve Dayanıklılık\r\nUygulama: Bilek, boyun, kulak arkası gibi nabız noktalarına sıkılır\r\n\r\nKalıcılık: İçeriğe ve cilt tipine bağlı olarak 2–12 saat arası\r\n\r\nSaklama: Direkt güneş ışığından uzak, serin yerde saklanmalı\r\n\r\n";
            showdialog(name, cost, explation, Properties.Resources.parfüm);
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            string name = "saç köpüğü";
            string cost = "150 TL";
            string explation = "\U0001f9f4 Temel Özellikler\r\nÜrün Adı: Saç Köpüğü\r\n\r\nTanım: Saça hacim, şekil ve tutuculuk kazandırmak için kullanılan, hafif ve kabarık yapıda şekillendirici ürün\r\n\r\nKullanım Alanı: Günlük saç şekillendirme, özel saç stilleri, hacim kazandırma\r\n\r\n\U0001f9ea İçerik Özellikleri\r\nTemel Bileşenler:\r\n\r\nPolimerler (şekil verme ve tutuculuk sağlar)\r\n\r\nNemlendiriciler (saçın kurumasını önler)\r\n\r\nHafif yağlar veya vitamin takviyeleri (bazı ürünlerde)\r\n\r\nAlkol İçeriği: Bazı köpüklerde bulunur, hızlı kuruma sağlar\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nForm: Aerosol sprey tüpte, köpük formunda çıkar\r\n\r\nKıvam: Hafif, kabarık, kremsi köpük\r\n\r\nUygulama Şekli: El ile alınarak nemli veya kuru saça uygulanır\r\n\r\nKurutma Süresi: Hızlı kurur, fönle şekillendirilebilir\r\n\r\n💇‍♀️ Fonksiyonel Özellikler\r\nEtkileri:\r\n\r\nHacim verir\r\n\r\nSaç modelini sabitler\r\n\r\nKıvırcık saçları belirginleştirir\r\n\r\nElektriklenmeyi azaltabilir\r\n\r\nTutuş Gücü: Hafif – Orta – Güçlü (ürüne göre değişir)\r\n\r\n\U0001f9fc Kullanım ve Temizlik\r\nGünlük kullanım için uygundur\r\n\r\nSaçı ağırlaştırmaz, kolay durulanır\r\n\r\nYıkanmadan önce saçtan kolayca taranabilir\r\n\r\n🎨 Tasarım\r\nŞık, genellikle metal tüp şişelerde sunulur\r\n\r\nBasmalı başlık ile kolay kullanım sağlar\r\n\r\n";
            showdialog(name, cost, explation, Properties.Resources.saç_köpüğü);
        }

        private void simpleButton20_Click(object sender, EventArgs e)
        {
            string name = "saç kremi";
            string cost = "120 TL";
            string explation = "\U0001f9f4 Temel Özellikler\r\nÜrün Adı: Saç Kremi\r\n\r\nTanım: Saçı yumuşatmak, nemlendirmek, kolay taranmasını sağlamak ve elektriklenmeyi önlemek amacıyla kullanılan bakım ürünü\r\n\r\nKullanım Alanı: Banyo sonrası bakım, saç yumuşatma ve onarma\r\n\r\n\U0001f9ea İçerik Özellikleri\r\nTemel Bileşenler:\r\n\r\nSilikonlar (pürüzsüzlük sağlar)\r\n\r\nBitkisel yağlar (argan, hindistancevizi, zeytin yağı)\r\n\r\nProtein ve keratin (onarıcı etki)\r\n\r\nVitaminler (B5, E, vb.)\r\n\r\nAlkol ve Paraben: Bazı ürünlerde bulunur; hassas saç tipleri için dikkat edilmeli\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nForm: Krem (akışkan veya yoğun kıvamlı)\r\n\r\nUygulama Şekli: Şampuan sonrası nemli saça uygulanır, genellikle birkaç dakika bekletilip durulanır\r\n\r\nDurulama Türü:\r\n\r\nDurulanan saç kremi\r\n\r\nDurulanmayan (leave-in) saç kremi\r\n\r\n💇‍♀️ Fonksiyonel Özellikler\r\nEtkileri:\r\n\r\nSaçı yumuşatır ve nemlendirir\r\n\r\nSaç uçlarındaki kırıkları azaltır\r\n\r\nKolay tarama sağlar\r\n\r\nSaç elektriklenmesini ve kabarmayı önler\r\n\r\nSaçı güneş, ısı ve çevresel etkilere karşı koruyabilir\r\n\r\n\U0001f9fc Kullanım ve Temizlik\r\nGünlük veya haftalık kullanım için uygundur\r\n\r\nSaçtan kolayca durulanır\r\n\r\nYağlı saçlar için hafif formüller tercih edilmeli\r\n\r\n🎨 Tasarım\r\nTüp, pompalı şişe veya kavanoz formunda sunulur\r\n\r\nGenellikle hoş kokulu ve pratik kapaklı ambalajlar\r\n\r\nİstersen saç tipine (kuru, yağlı, boyalı, ince telli vs.) göre uygun saç kremi türleri hakkında da de";
            showdialog(name, cost, explation, Properties.Resources.saç_kremi);
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            string name = "sırt çantası";
            string cost = "350 TL";
            string explation = "🎒 Temel Özellikler\r\nÜrün Adı: Sırt Çantası\r\n\r\nTanım: Eşyaları taşıma amacıyla iki omuzla kullanılan, arka sırta oturan taşıma çantası\r\n\r\nKullanım Alanı: Okul, günlük kullanım, seyahat, spor, kamp\r\n\r\n\U0001f9f5 Malzeme Özellikleri\r\nAna Malzeme:\r\n\r\nPolyester, kanvas, naylon, deri veya su geçirmez kumaş\r\n\r\nAstar: Genellikle polyester veya pamuklu kumaş\r\n\r\nFermuarlar: Metal veya plastik, genellikle çift yönlü\r\n\r\n📏 Mekanik / Fiziksel Özellikler\r\nBoyutlar:\r\n\r\nKüçük (10–15 L), Orta (20–30 L), Büyük (35 L ve üzeri)\r\n\r\nBölmeler:\r\n\r\nAna göz\r\n\r\nLaptop bölmesi (korumalı)\r\n\r\nÖn cep, yan suluk cepleri\r\n\r\nGizli cep (bazı modellerde)\r\n\r\nAğırlık Taşıma: Ortalama 5–15 kg arası (modele bağlı)\r\n\r\n\U0001f9f0 Fonksiyonel Özellikler\r\nAskılar: Ayarlanabilir, yumuşak dolgulu omuz askıları\r\n\r\nSırt Kısmı: Nefes alabilir ve destekli sünger panel\r\n\r\nEk Özellikler:\r\n\r\nUSB girişli modeller\r\n\r\nSu geçirmezlik\r\n\r\nKulaklık çıkışı\r\n\r\nYansıtıcı şeritler (güvenlik için)\r\n\r\n🎨 Tasarım ve Stil\r\nRenk Seçenekleri: Siyah, gri, mavi, yeşil, desenli vs.\r\n\r\nTasarım Tarzı:\r\n\r\nSpor\r\n\r\nKlasik\r\n\r\nŞehir tipi\r\n\r\nOutdoor / trekking tarzı\r\n\r\n\U0001f9fc Kullanım ve Temizlik\r\nHafif nemli bezle temizlenebilir\r\n\r\nBazı kumaş modeller elde yıkanabilir\r\n\r\nDeri olanlar özel bakım gerektirir\r\n\r\n";
            showdialog(name, cost, explation, Properties.Resources.sırt_cantası);
        }

        private void simpleButton24_Click(object sender, EventArgs e)
        {
            ShowProductByName("kalem");
        }

        private void simpleButton23_Click(object sender, EventArgs e)
        {
            string name = "defter";
            string cost = "38.000 TL";
            string explation = "";
            showdialog(name, cost, explation, Properties.Resources.defter);
        }

        private void simpleButton25_Click(object sender, EventArgs e)
        {
            string name = "kalem kutu";
            string cost = "38.000 TL";
            string explation = "";
            showdialog(name, cost, explation, Properties.Resources.playstatıon);
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
            lblorder(lbl_order);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listBoxControl1.Items.Clear();
            Form1.customerForm.lbl_order.Text = "0,00 TL";
        }
    }
}



