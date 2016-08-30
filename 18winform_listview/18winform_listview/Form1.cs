using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18winform_listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboboxların başlangıç değerini verdik yani ilk değerin seçili olmasını getirdik.
            comboBox1.SelectedIndex=0;
            comboBox2.SelectedIndex = 0;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //listboxa ne verirsek ekliyordu(çünkü obje tipinde birşey istiyordu obje tipide her değeri alıyor zaten)

            
            ListViewItem lvi = new ListViewItem();//turquaz renkli elemanlar referans tipli elemanlardır.nesne olarak kullanıyoruz

            lvi.Text= txtIsim.Text;//ilk kolon
            lvi.SubItems.Add( txtSoyisim.Text);//ikinci kolon

            string telefon = string.Format("{0} {1} {2}",comboBox1.Text,comboBox2.Text,mskdTelefon.Text);
            lvi.SubItems.Add(telefon);//üçüncü kolon

            lvi.SubItems.Add(dtpDogumTarihi.Value.ToShortDateString());//tarihi kısalt ve stringe çevirerek at.//dördüncü kolon

            listView1.Items.Add(lvi);//ListViewItem tipinde birşey istiyor bizde lvi verdik.

        }

       
    }
}
