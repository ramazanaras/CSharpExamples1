using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17winform_geneluygulamalar
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
        //TC KİMLİK NO DOĞRULAMA
        private void button1_Click(object sender, EventArgs e)
        {
            //Not:Tc kimlik no ların sonu çift hanelidir.
            //Not:Tc Kimlik numarasının ilk 10 hanesinin toplamının birler basamağı son haneye eşit olmalıdır
            //Not:maskedTextBox1.MaskFull bize true yada false döndürür


            if (maskedTextBox1.MaskFull)//true ise    
            {
                //string tipi hem değişken gibi hemde dizi gibi(char dizisi) davranır.
                string sonHane = maskedTextBox1.Text[10].ToString();//son  haneyi string tipinde aldık
                int sonHaneNum = Convert.ToInt32(sonHane);
                if (sonHaneNum % 2 != 0)//2 ile kalan 0 değilse
                {
                    MessageBox.Show("TCKN Hatalıdır");
                }
                else
                {
                    //ilk 10 haneyi alcaz.
                    int toplam = 0;
                    for (int i = 0; i < maskedTextBox1.Text.Length - 1; i++)
                    {
                        string rkm = maskedTextBox1.Text[i].ToString();
                        toplam += Convert.ToInt32(rkm);//ilk 10 haneyi topladık..
                    }
                    if (toplam % 10 == sonHaneNum)
                    {
                        MessageBox.Show("Tc kimlik no Doğrudur");
                    }
                    else
                    {
                        MessageBox.Show("Tc kimlik no Hatalıdır");
                    }
                }
            }
            else//false ise
            {
                MessageBox.Show("Lütfen 11 haneli bir TCKN girin");
            }
           


        }


    }
}
