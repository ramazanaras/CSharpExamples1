using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21winfom_dialogwindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFontDialog_Click(object sender, EventArgs e)
        {
            //Bütün dialog pencerelerinin Show veya ShowDialog isminde metodları bulunur.Bu metodlar dialog pencerelerini açmayı sağlar.(Showdialogda pencerenin arka kısmına geçiş yapılmıyor.)

            DialogResult sonuc = fontDialog1.ShowDialog();//Tüm dialog pencereleri geriye DialogResult tipinde değer dönderir.
            //MessageBox.Show'da geriye bir dialog penceresidir.

            if (sonuc==DialogResult.OK)//eğer Ok'ye basmışsa(tamam butonu)
            {
                //fontDialog1.Font özelliği içerisinde  fontDialog penceresinden seçilen font değerleri tutulur.
                lblDenemeTahtasi.Font = fontDialog1.Font;//kullanıcının seçmiş oludğu fontu labelin fontuna attık. 
            }
            else//basmamışsa
            {
                MessageBox.Show("seçim yapmadınız");
            }
            
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            //ınitialDirectory özelliği varsayılan dosya konumunu açmayı sağlar .
            openFileDialog1.InitialDirectory=@"C:\Users\RAMAZAN\Documents";//@ hata bastırma kodu denilebilir.(\ kaçış karakteridir.phpdede vardı @ hata bastırma kodu)
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpeg)| *.jpeg|Jpg Dosyası(*.jpg)|*.jpg|Png Dosyası(*.png)|*.png|Gif Dosyası(*.gif)|*.gif";//asıl filtreleme | sonraki uzantıdır.Diğerleri onun ne olduğunu söyler.

            openFileDialog1.Title = "Resim Dosyası seçiniz";

          DialogResult sonuc=openFileDialog1.ShowDialog();
          if (sonuc==DialogResult.OK)//kullanıcı aç'a basmışsa
          {
              lblDenemeTahtasi.Text = openFileDialog1.FileName;//dosyanın adını ve bulunduğu dizinle beraber veriyor.(C:\Users\RAMAZAN\benim resimlerim\ben2.jpg)
              lblDeneme2.Text = openFileDialog1.SafeFileName;//seçilen dosyanın sadece ismini verir.(ben2.jpg)
          }
          else//iptale basmışsa
          {
              MessageBox.Show("seçim yapmadınız");
          }
        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Kaydedilecek Dosyayı seçiniz";
            DialogResult sonuc = saveFileDialog1.ShowDialog();
          
            if (sonuc==DialogResult.OK)//kaydet'e basıldıysa
            {
                lblDenemeTahtasi.Text = saveFileDialog1.FileName;
            }
            else//iptale basmışsa
            {
                MessageBox.Show("seçim yapmadınız");
            }
        }

        private void btnFolderBrowserDialog_Click(object sender, EventArgs e)
        {
            DialogResult sonuc=folderBrowserDialog1.ShowDialog();
            if (sonuc==DialogResult.OK)//tamam'a basıldıysa
            {
                lblDenemeTahtasi.Text = folderBrowserDialog1.SelectedPath;//seçili yolu bize verir.
            }
            else//iptale basmışsa
            {
                MessageBox.Show("seçim yapmadınız");
            }

        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = colorDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)//tamam'a basıldıysa
            {
                lblDenemeTahtasi.ForeColor = colorDialog1.Color;//seçmiş olduğumuz rengi label'e atadık.( lblDenemeTahtasi.ForeColor Color tipinde değer istiyor bizde colorDialog1.Color Color tipinde değer verdik.)
                lblDeneme2.BackColor = colorDialog1.Color;
            }
            else//iptale basmışsa
            {
                
            }
        }
    }
}
