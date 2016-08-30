using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29winform_otobusotomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //combobox değeri değiştiğinde 
        private void cmbOtobus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbOtobus.Text)
            {
                case "Travego":
                    KoltukDoldur(8,false);//false :arka koltuk 4lü true olursa arka koltuk beşli olacak.8 dediğimiz kaç sıra olduğu her sırada 4 koltuk olacak
                    break;

                case "Setra":
                     KoltukDoldur(12,true);
                    break;

                case "Neoplan":
                     KoltukDoldur(10,false);
                    break;

                default:
                    break;
            }
        }

        //KoltukDoldur metodu 
        void KoltukDoldur(int sira, bool arkaBesliMi)
        {
            yavaslat:
            //butonları temizliyeceğiz burda yeni gelenler üstüne eklemesin diye
            foreach (Control ctrl in this.Controls)//this:bu form demek
            {
                if (ctrl is Button)
                {
                    Button btn = ctrl as Button;//cast işlemi yaptık  (Button)ctrl 'de yapabilirdik
                    if (btn.Text=="Kaydet")//kaydet butonunu kaldırmamamız lazım
                    {
                        continue;//bir sonraki adıma geç
                    }
                    else
                    {
                        this.Controls.Remove(ctrl);//formdan butonları kaldır.
                        goto yavaslat;//butonları silerken bazılarını siliyor diğerlerini silmiyor gibi bir karmaşa vardı bunu önlemek için yaptık
                    }
                }

            }


            //koltukları ekleme işlemleri
            int koltukNo = 1;
            for (int i = 0; i < sira; i++)//8 sıra gibi
            {
                for (int j = 0; j <5 ; j++)//4 koltuk + ortadaki boşluk için 5 dedik
                {
                    if (i==sira/2  && j>2)//orta sıranın sağında kolutk olmayacak orta kapı kısmı
                    {
                        continue;
                    }


                    if (arkaBesliMi==true)//arka sıra 5li olacaksa
                    {
                        if (i!=sira-1 && j==2)//arka beşli gelmiş ve de son sıraya gelmişse
                        {
                            continue;//bir sonraki adıma geç(kendine en yakın döngüyü bir sonraki adıma geçirir.)
                        }
                    }
                    else//arka beşli gelmemişse
                    {
                        if (j == 2)
                        {
                            continue;//sonraki adıma geç(yani ortadaki butonları eklememek için)
                        }
                    }


                    
                    Button koltuk = new Button();//koltukları(butonları) oluşturuyoruz.
                    koltuk.Height = koltuk.Width = 40;
                    koltuk.Top = 30+(i*45);//formun üst kısmından ilk buton 30 pixel aşağıdan başlasın.yani koltukları alt alta düzgün şekilde hizaladık.
                    koltuk.Left = 5+(j*50);//formun solundan ilk buton  5 piksel uzakta
                    koltuk.Text = koltukNo.ToString();//koltuğun üzerindeki yazı
                    koltukNo++;

                    koltuk.ContextMenuStrip = contextMenuStrip1;//butonlara(koltuklara contextmenu strip sağ tık şeyi ekledik)

                    koltuk.MouseDown += koltuk_MouseDown;//butona sağ tıkladığımızda(normal click eventi butona sol tıkladığımızda çalışır onun yerine mouse down yaparak tıklandığında yaptık yani sağ ve sol tık farketmez diye )

                    this.Controls.Add(koltuk);//forma koltuğu ekliyoruz.//this:bu form
                }
            }
        }

        Button tiklanan;//global değişken (class düzeyinde)
        void koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;
          
        }

      

        //rezerve et sağ tık şeyi
        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tiklanan.Tag == (object)"RezerveEdilmiş")//rezerve edilmişse
            {
                MessageBox.Show("Bu koltuk daha önce rezerve edilmiş");
            }
            else//rezerve edilmemişse
            {
                //error provider başlangıç(error provider controllerin yanında oluşan hata uyarıları yapar.)
                if (cmbOtobus.SelectedIndex==-1)//bu combobox seçilmemişse
                {
                    errorProvider1.SetError(cmbOtobus,"Otobüs seçiniz");
                }
                if (cmbNerden.SelectedIndex == -1)//bu combobox seçilmemişse
                {
                    errorProvider1.SetError(cmbNerden, "Boş geçilemez");

                }
                if (cmbNereye.SelectedIndex == -1)//bu combobox seçilmemişse
                {
                    errorProvider1.SetError(cmbNereye, "Boş geçilemez");
                }
                //error provider bitiş

                if (cmbOtobus.SelectedIndex == -1 || cmbNerden.SelectedIndex == -1 || cmbNereye.SelectedIndex == -1)//bu üç comboboxtan herhangi biri seçilmemişse
                {
                    MessageBox.Show("Lütfen önce gerekli alanları doldurun");
                    return;//return demek metodu sonlandırır demektir.aşağıda else yapmaya gerek kalmaz.(aşağısındaki hiçbir kodu çalıştırmaz)
                }
                KayitFormu kf = new KayitFormu();//turquaz renkli(referans tipli olduğu için new ile yapıyoruz)
                // kf.Show();//show ile açınca arkada kontrolü kitlemez
                DialogResult sonuc = kf.ShowDialog();//kayitformunu açar //showdialog olunca arkadaki formu kitler.bu form kapanmadan arkadaki kontrolde işlem yapamayız



                if (sonuc == DialogResult.OK)//tamam butonuna basıldıysa
                {
                    // MessageBox.Show("DialogResult OK Geldi");

                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = string.Format("{0} {1}", kf.txtIsim.Text, kf.txtSoyIsim.Text);//1.kolon
                    lvi.SubItems.Add(kf.mskdTelefon.Text);//2.KOLON
                    if (kf.rdbBay.Checked)
                    {
                        lvi.SubItems.Add("BAY");//3.kolon
                        tiklanan.BackColor = Color.Blue;//rezerve edilen koltuğun rengini değiştirdik.

                    }
                    if (kf.rdbBayan.Checked)
                    {
                        lvi.SubItems.Add("BAYAN");
                        tiklanan.BackColor = Color.Pink;
                    }
                    lvi.SubItems.Add(cmbNerden.Text);//4.kolon
                    lvi.SubItems.Add(cmbNereye.Text);//5.kolon

                    lvi.SubItems.Add(tiklanan.Text);//tıklanan butonun(koltuğun numarasını ekledik)
                    lvi.SubItems.Add(dtpTarih.Text);
                    lvi.SubItems.Add(nudFiyat.Value.ToString());

                    listView1.Items.Add(lvi);//listviewe ekledik.

                    tiklanan.Tag = "RezerveEdilmiş";//koltuğun daha önce rezerve edilip edilmediğini kontrol etmek için tag özelliğini kullandım yukarıdada if ile kontrolüünü yaptım 


                }
                else if (sonuc == DialogResult.Cancel)//iptal butonuna basıldıysa
                {
                    //MessageBox.Show("DialogResult cancel Geldi");
                }
            }

            


        }


    }
}
