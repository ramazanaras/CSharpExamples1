using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28winform_runtimeuygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipler.SelectedIndex = 0;//ilk elemanı seçili hale getirecek
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(nudAdet.Value);
            flowLayoutPanel1.Controls.Clear();//controlleri temizliyoruz.
            for (int i = 0; i < adet; i++)
            {
                switch (cmbTipler.Text)
                {
                    case "Button": 
                        Button btn = new Button();//yeni buton oluştur
                        btn.Height = 30;
                        btn.Width = 80;
                        btn.Text = string.Format("Button {0}", i + 1);//butonun üzerindeki isim(Button 1,Button 2 şeklide)

                        btn.Font = new Font("Tahoma", 10);//btn.Font=Font.Bold gibi tek tek özellikler yerine bu şekildede çoklu şeyler yapabiliriz.

                        btn.BackColor = Color.Gray;
                        btn.Click += btn_Click;//çalışma zamanında oluşan butonların click eventi(aşağıdada metodu var)(+= tab tab yaparız.)

                        btn.MouseHover += btn_MouseHover;//mouse üzerine gelindiğinde 
                        btn.MouseLeave += btn_MouseLeave;//mouse butonun üzerinden ayrıldığında
                        btn.MouseEnter += btn_MouseEnter;  //mouse ile üzerine gelindiğinde çalışır
                        //Not:flowlayout içerisindeki controlleri düzenli biçimde sıralar.
                        flowLayoutPanel1.Controls.Add(btn);//butonu flowlayouta ekledik.(oluşturduk.)
                        break;
                        
                    case "Combobox":
                        //Girilen adet kadar combobox üretilecek.Her comboboxın itemlarına eleman eklenecek.SelectedIndexChanged eventi tanımlanacak.Bu eventte seçilen elemanın ismi messagebox ile gösterilecek.Comboboxların dropdownstyle özelliği dropdownlist olacak(yani comboboxa dışarıdan veri girilemeyecek kapalı olcak).  Her combobox flowlayoutpanel'e eklenecek.

                        ComboBox cmb = new ComboBox();
                        cmb.Items.Add("Item 1");
                        cmb.Items.Add("Item 2");
                        cmb.Items.Add("Item 3");

                        cmb.DropDownStyle = ComboBoxStyle.DropDownList;//Not:atama yapmak için şu yolu izleyebiliriz.cmb.DropDownStyle bize ComboBoxStyle tipinde değer istiyor eşitlikten sonra ComboBoxStyle ile başlayıp . koyarak özelliği(DropDownList) atayabiliriz.(ingiliz anahtarı yani özelliklere atama eşittir ile yapılır.)

                        cmb.SelectedIndexChanged += cmb_SelectedIndexChanged;//aşağıda metodu oluştu

                        flowLayoutPanel1.Controls.Add(cmb);//flowlayouta comboboxı ekledik.
                        break;

                    case "Picturebox":

                        break;

                    case "Textbox":

                        break;

                    case "Listbox":

                        break;

                    default:
                        break;
                }
            }
        }
        //combobox'ın eventi(comboboxın içindeki değerleri değiştirdiğimizde)
        void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox secilen = sender as ComboBox;//(Combobox) sender ilede cast yapabiliriz(yani senderı(objeyi) Combobox tipine dönüştürdük.)
            MessageBox.Show(secilen.Text);//mesajla içeriğindeki yazıyı gösteriyoruz.
        }

        //mouse ile üzerine gelindiğinde çalışır(mouse hovera göre daha hızlı çalışır)
        void btn_MouseEnter(object sender, EventArgs e)
        {
            Button tik = sender as Button;
            tik.BackColor = Color.Green;
        }
        //mouse butondan ayrıldığında
        void btn_MouseLeave(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;//sender as Button 'da yazabilirdik
            tiklanan.BackColor = Color.Gray;
        }

        //mouse ile üzerine gelindiğinde çalışır
        void btn_MouseHover(object sender, EventArgs e)
        {
          //üzerine gelinen butonun hangi butonun olduğunu algılamam lazım sender ile alırız.
            Button tiklanan = sender as Button;//cast ettik (Button)sender 'da yapabilirdik
            //tiklanan.BackColor = Color.Red;
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button tiklanan = sender as Button;
            MessageBox.Show(string.Format("{0}'e Tıklandı.", tiklanan.Text));
        }
    }
}
