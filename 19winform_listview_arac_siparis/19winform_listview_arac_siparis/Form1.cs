using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19winform_listview_arac_siparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dtpYil_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = colorDialog1.ShowDialog();//color dialogun açılmasını sağlar.(showdialog baskın gelir alttaki pencereyi tıklayamazsın.show ile farkı bu)Bütün dialog pencereleri geriye dialog result tipinde deeğer döndürür

            if (sonuc == DialogResult.OK)//demekki kullanıcı renk seçmiş ve Ok 'ye basmıştır
            {
                btnRenk.BackColor = colorDialog1.Color;//butonun arka plan rengini değiştirdik.
            }
            else
            {
                MessageBox.Show("Renk seçmediniz");
            }










        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();//comboboxı temizledik
            switch (cmbMarka.Text)
            {
                case "VOLKSWAGEN":

                    cmbModel.Items.Add("JETTA");
                    cmbModel.Items.Add("PASSAT");
                    cmbModel.Items.Add("CC");
                    break;

                case "AUDİ":
                    cmbModel.Items.Add("A7");
                    cmbModel.Items.Add("Q7");
                    cmbModel.Items.Add("R8");
                    break;

                case "BMW":
                    cmbModel.Items.Add("M6 COUPE");
                    cmbModel.Items.Add("X6");
                    cmbModel.Items.Add("5.25");
                    break;

                case "MERCEDES":
                    cmbModel.Items.Add("200 AMG");
                    cmbModel.Items.Add("E 250");
                    cmbModel.Items.Add("CLA 200");
                    break;

                case "RENAULT":
                    cmbModel.Items.Add("CLİO");
                    cmbModel.Items.Add("LAGUNA");
                    cmbModel.Items.Add("SYMBOL");
                    break;
                case "HYUNDAI":
                    cmbModel.Items.Add("ACCENT");
                    cmbModel.Items.Add("I30");
                    cmbModel.Items.Add("IX 35");
                    break;
                case "HONDA":
                    cmbModel.Items.Add("CIVIC");
                    cmbModel.Items.Add("CITY");
                    cmbModel.Items.Add("CRV");
                    break;


                default:
                    break;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();//referans tipli(turquaz renkli olduğu için) new ile tanımlıyoruz
            lvi.UseItemStyleForSubItems = false;//listviewdeki alt elemanların özelliklerini değiştirebilmek için false yapmamız lazım yoksa aşağıdaki renk değişimi olmaz.

            lvi.Text = cmbMarka.Text;//ilk kolon
            lvi.SubItems.Add(cmbModel.Text);//ikinci kolon
            lvi.SubItems.Add(cmbYakitTipi.Text);//üçüncü kolon
            lvi.SubItems.Add(cmbKasaTipi.Text);//dördüncü kolon
            lvi.SubItems.Add(cmbVitesTipi.Text);//beşinci kolon
            lvi.SubItems.Add(cmbMotorTipi.Text);//altıncı kolon

            lvi.SubItems.Add(string.Empty);//7.kolon(içine boş birşey ekleddiki aşağıdaki rengi uygulayabilelim)
            lvi.SubItems[6].BackColor = btnRenk.BackColor;//7.kolon (listviewde yukarıda  lvi.UseItemStyleForSubItems = false yaptığımız için renk değiştirilebiliyor yazmasaydık değiştirilemezdi )

            lvi.SubItems.Add(dtpYil.Text);

            listView1.Items.Add(lvi);//ListViewItem tipinde(lvi) bir değer alır.


            //ekle butonuna bastıktan sonra comboboxları seçili yapmamak için(cmbMarka.SelectedIndex = -1; yapmamız gerekir)

            //cmbMarka.SelectedIndex = -1;
            //cmbModel.SelectedIndex = -1;
            //cmbYakitTipi.SelectedIndex = -1;
            //cmbKasaTipi.SelectedIndex = -1;
            //cmbVitesTipi.SelectedIndex = -1;
            //cmbMotorTipi.SelectedIndex = -1;    //bunları yazmak yerine aşağıdaki gibi yapabiliriz

            foreach (Control ctrl in this.Controls)//this:Form demek  this.Controls-->formun kontrolleri
            {
                //is komutu ctrl elemanı Combobox mı diye sormayı sağlar.Eğer combobox ise true gelir değilse false gelir.
                //gelen ctrl elemanı şu tip mi diye sorgulamak için is komutu kullanılır.
                //Bir değişkeni değerine göre sorgulamak için == kullanılırken ,o değişkeni tipine göre sorgulamak için is komutu kullanılır.
                if (ctrl is ComboBox)//gelen control(ctrl) Combobox mı diye bakıyoruz
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;//ctrl elemanını combobox tipine dönüştürdük(cast işlemi yaptık.)

                }
                else if (ctrl is Button)//eğer butonsa butonun rengini eski haline getirdik.
                {
                    Button btn = (Button)ctrl;//ctrl(Control tipindeydi bunu cast ederek(dönüştürerek) buton tipinde yaptık.)
                    if (btn.Name == "btnRenk")//btnRenk butonunu eski haline getir.
                    {
                        ((Button)ctrl).BackColor = Color.LightGray;
                    }

                }
                else if (ctrl is TextBox)//eğer textbox ise
                {
                    ((TextBox)ctrl).Text = string.Empty;//textboxın içini boşalt.
                }
                else if (ctrl is DateTimePicker)//eğer datetimepicker ise
                {
                    //DateTime.Now sistem saat ve tarihini getirir
                    ((DateTimePicker)ctrl).Value = DateTime.Now;//şu anki tarihi getir.
                }


            }


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Not:listView1.Items.Remove bize ListViewItem tipinde bir eleman istiyor bizde listView1.SelectedItems[0] bunu verdik.
            if (listView1.SelectedItems.Count > 0)//seçili elemanlar 0 dan büyükse yani birşey seçmişssek
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);//yani seçtiğim seçili elemanlardan ilk elemanı kaldır.   
            }
            else
            {
                MessageBox.Show("Hiç eleman seçilmedi");
            }

        }

        //Not:değişkenlerin ömrü iki scope(parantez) arasındadır.(yani başka yerden ulaşamayız o yüzden global olarak tanımlamamız gerekir.)

        //class düzeyinde değişken tanımlama(global değişken)
        ListViewItem secili;//global olarak tanımladıkki aşağıdaki btnKaydettede kullanabilelim.
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)//listviewda bir eleman seçmemişsek 
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz kaydı seçiniz");
                return; //bundan sonraki komutların çalışmasını durdurur.(yani metodu sonlandırır.)//içerisinde bulunduğu metodu sonlandırır.Altında gelen hiçbir kod satırını çalıştırmaz.
            }

            //seçili elemanları düzenleyeceğiz şimdi
            secili = listView1.SelectedItems[0];//istView1.SelectedItems[0]; bize ListViewItem tipinde değer döndürür.
            cmbMarka.Text = secili.Text;//ilk kolonu comboboxa koyduk
            cmbModel.Text = secili.SubItems[1].Text;//ikinci kolonu comboboxa koyduk.
            cmbYakitTipi.Text = secili.SubItems[2].Text;//üçüncü kolonu comboboxa koyduk.
            cmbKasaTipi.Text = secili.SubItems[3].Text;//dördüncü kolonu comboboxa koyduk.
            cmbVitesTipi.Text = secili.SubItems[4].Text;//beşinci kolonu comboboxa koyduk.
            cmbMotorTipi.Text = secili.SubItems[5].Text;//altıncı  kolonu comboboxa koyduk.
            btnRenk.BackColor = secili.SubItems[6].BackColor;//6.kolonun arka plan rengini butonun arka plan rengi yap.
            dtpYil.Value = Convert.ToDateTime(string.Format("01.01.{0}", secili.SubItems[7].Text));

            //dtpYil.Value = Convert.ToDateTime(string.Format("01.01.{0}",secili.SubItems[7].Text));//( dtpYil.Value Datetime tipinde--secili.SubItems[7].Text string tipinde )cast edemeyiz benzer tipler değil o yüzden convert ediyoruz.
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //değerleri yenilerle değiştiriyoruz.
            secili.SubItems[0].Text = cmbMarka.Text;
            secili.SubItems[1].Text = cmbModel.Text;
            secili.SubItems[2].Text = cmbYakitTipi.Text;
            secili.SubItems[3].Text = cmbKasaTipi.Text;
            secili.SubItems[4].Text = cmbVitesTipi.Text;
            secili.SubItems[5].Text = cmbMotorTipi.Text;
            secili.SubItems[6].BackColor = btnRenk.BackColor;
            secili.SubItems[7].Text = dtpYil.Text;

        }
        //Not:Keypress bir tuşa basılıp çekildiğinde çalışır

        //listView1'de herhangi bir tuşa basıldığında çalışır(keydown)
        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            //KeyCode:Basılan tuşun code'unu tutar.
            if (e.KeyCode == Keys.Delete)//delete tuşuna basıldığında çalışır
            {
                if (listView1.Items.Count > 0)//seçili elemanlar 0 dan büyükse yani birşey seçmişssek
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);//yani seçtiğim seçili elemanlardan ilk elemanı kaldır.  
                }
                else
                {
                    MessageBox.Show("Hiç eleman seçilmedi");
                }
            }
        }

        //contextmenustripteki sil kısmına basıldığında çalışır.
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)//seçili elemanlar 0 dan büyükse yani birşey seçmişssek
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);//yani seçtiğim seçili elemanlardan ilk elemanı kaldır.
            }
        }

        //Not:Context menu strip herhangi bir kontrole sağ tıkladığımızda çalışan şeydir
//kontrolün Context menu strip özelliğinden contexmenustrip1 i seç

    }
}
