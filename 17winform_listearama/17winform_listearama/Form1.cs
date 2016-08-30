using System;
using System.Collections;//ArrayList için kullandık
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17winform_listearama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtIsim.Text!=string.Empty)//textbox boş değilse ekleme yapıcaz
            {
                //Toupper büyük harfe çevirir
                listBox1.Items.Add(txtIsim.Text.ToUpper());//listbox obje alır(yani içine istediğimizi atabilriiz)
                txtIsim.Clear();
                txtIsim.Focus();//imleç bunun üzerinde olur.
            }
        }

        private void btnKisiSayisi_Click(object sender, EventArgs e)
        {
            int adet = listBox1.Items.Count;//elemanların sayısını alabiliriz.
            MessageBox.Show(adet.ToString());
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtIsimAra.Text!=string.Empty)//textbox boş değilse
            {
                string isim = txtIsimAra.Text.ToUpper().Trim();//Trim sağdan soldan boşlukları alır.
                if (listBox1.Items.Contains(isim)==true)//listbox elemanları isimi içeriyorsa
                {
                    MessageBox.Show("Aranan isim listede var");
                }
                else//listbox elemanları isimi içermiyorsa
                {
                    MessageBox.Show("Aranan isim listede yok");
                }
            }
            else
            {
                MessageBox.Show("Lütfen aranacak kelime girin");
            }
        }

        private void txtIsimAra_TextChanged(object sender, EventArgs e)
        {
            //her karakter girdiğimiz zaman çalışır

            string aranan = txtIsimAra.Text.ToUpper().Trim();
            ArrayList isimler = new ArrayList();//ctrl + . ile yukarıda using ile eklendi
            //ArrayList obje tutar(boyut belirtmeye gerek yoktur.)Arraylist daha esnek yapıdadır.

            //foreach hata verir çünkü koleksiyonu değiştirmeye çalıyoruz ama foreachde koleksiyon yapısı değiştirilemez.
            //foreach (string item in listBox1.Items)//listBox1.Items-->bu bir koleksiyondur
            //{
            //    if (!item.Contains(aranan))//item arananı içermiyorsa
            //    {
            //        listBox1.Items.Remove(item);
            //    }
            //    else
            //    {

            //    }
            //}

            for (int i = 0; i < listBox1.Items.Count; i++)//listboxtaki elemanları isimeler dizisine attık
            {
                isimler.Add(listBox1.Items[i].ToString());//listbox obje olduğu için objeyi stringe atmak için ToString() yaptık.
            }
            foreach (string item in isimler)
            {
                if (!item.Contains(aranan))//item arananı içermiyorsa  Not:contains harf harf içermeye bakıyor(Mesela item=Ali aranan=Al bile olsa true döner.)
                {
                    listBox1.Items.Remove(item);
                }
            }
           
        
        }
    }
}
