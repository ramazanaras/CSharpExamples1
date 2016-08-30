using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15winform_listeleyiciler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtIsım.Text.Trim()!="")//textbox boş değilse ekleme yap.//trim:sağdan soldan boşlukları al demektir.
            {
                //string isim = txtIsım.Text;

                string isim = string.Format("{0}-{1}", listKisiler.Items.Count + 1, txtIsım.Text.Trim());//6-ramazan ,5-ahmet diye ekler.
                listKisiler.Items.Add(isim);//listoxa ekleme işlemi yapar.(bizden obje tipinde değer ister(objede her değeri verebiliriz aldığı tipe dönüşür .int verebiliriz string verebiliriz vs.))

                //listKisiler.Items.Insert(0, isim);//her seferde elemeanı indexi 0 olan yere yani en üste ekle demektir.
                //   txtIsım.Text = "";//textboxı temizle.
                //txtIsım.Text = string.Empty;//textboxı temizler

                txtIsım.Clear();//textboxı temizler
                txtIsım.Focus();//textboxa focuslar
            }
        
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            /*bu kod hata verir çünkü foreachde biz değeri değiştiremiyoruz sadece okuyabiliyoruz(yani koleksiyonu(listKisiler.SelectedItems) değiştiremiyoruz.)
            //foreach (object item in listKisiler.SelectedItems)
            //{
            //    listKisiler.Items.Remove(item);
            //}
             * */

            //listKisiler.Items.Remove(listKisiler.SelectedItem);//seçili itemi sil

            //BİRDEN ÇOK SSEÇİLİ ELEMANLARI SİLMEK İÇİN
            string[] silinecekler=new string[listKisiler.SelectedItems.Count];
            for (int i = 0; i < listKisiler.SelectedItems.Count; i++)
            {
                silinecekler[i] = (string)listKisiler.SelectedItems[i];//benzer türler olduğu için cast işlemi yaptık.
            }
            foreach (string item in silinecekler)
            {
                listKisiler.Items.Remove(item);
            }


        }
        //Not:KeyPress Tuşa basıp çekitğinde çalışır

        private void listKisiler_KeyDown(object sender, KeyEventArgs e)
        {
            //BİR TUŞA BASILDIĞINDA ÇALIŞIR(keydown)   
            if (e.KeyCode==Keys.Delete)//eğer delete tuşuna basılırsa.
            {
                string[] silinecekler = new string[listKisiler.SelectedItems.Count];
                for (int i = 0; i < listKisiler.SelectedItems.Count; i++)
                {
                    silinecekler[i] = (string)listKisiler.SelectedItems[i];
                }
                foreach (string item in silinecekler)//her bir elemanı siliyoruz
                {
                    listKisiler.Items.Remove(item);
                }
            }
        }
    }
}
