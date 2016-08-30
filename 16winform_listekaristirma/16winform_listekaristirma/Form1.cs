using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16winform_listekaristirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
            if (listBox1.Items.Contains(isim)==true)//eleman içeriyorsa
            {
                MessageBox.Show("Girilen isim listede vardır.Lütfen farklı bir isim giriniz");
                textBox1.Clear();
                textBox1.Focus();
            }
            else//içermiyorsa
            {
                listBox1.Items.Add(isim);
                textBox1.Clear();//textboxı siler
                textBox1.Focus();//textboxa focuslar
            }
            
        }

        //LİSTBOXI KARIŞTIRDIK
        private void btnKaristir_Click(object sender, EventArgs e)
        {
                      string[] isimler=new string[listBox1.Items.Count];
                      Random rnd = new Random();
                      

                      for (int i = 0; i < listBox1.Items.Count; i++)
                      {
                          int sayi = rnd.Next(0,listBox1.Items.Count);//0 ile listbox elemanlarının adedi arasında rastgele sayı üret.(0,5 ise 5 dahil değil mesela)
                          string rastgele = listBox1.Items[sayi].ToString();//listbox obje tutar bunu string atmak için ToString() ile dönüştürdük.

                          //DİZİYE BENZERSİZ ATAMA YAPMAK İÇİN
                          if (isimler.Contains(rastgele)==false)//isimler dizisi rastgeleyi içermiyorsa
                          {
                              isimler[i] = rastgele;
                          }
                          else//içeriyorsa yeniden atama yapmak için i-- yapıcaz(yani işlemi tekrarlıcaz)
                          {
                              i--;
                          }
                      }

                      listBox1.Items.Clear();//listboxı temizle

            //listboxa karışık listeyi ekliyoruz.
                      foreach (string item in isimler)
                      {
                          listBox1.Items.Add(item);
                      }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //7.overloadı kullandık
         DialogResult sonuc = MessageBox.Show("Silmek istediğinize emin misiniz?(Are you sure?)","Silme Formu",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            

            if (sonuc==DialogResult.Yes)//Yes ise
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else//No ise
            {
                MessageBox.Show("Silmekten Vazgeçtiniz");
            }

        }
    }
}
