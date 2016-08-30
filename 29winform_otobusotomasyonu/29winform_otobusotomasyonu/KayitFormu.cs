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
    public partial class KayitFormu : Form
    {
        public KayitFormu()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;//bu formun dialog resultunu cancel gönder
            this.Close();//formu kapat
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (txtIsim.Text==string.Empty)//boşsa
            {
                errorProvider1.SetError(txtIsim, "Boş geçilemez");
            }
            if (txtSoyIsim.Text==string.Empty)
            {
                errorProvider1.SetError(txtSoyIsim, "Boş geçilemez");
            }

            if (txtIsim.Text!=string.Empty && txtSoyIsim.Text!=string.Empty )
            {
                //this:bu form
                this.DialogResult = DialogResult.OK;//bu formun dialog resultunu ok gönder
                this.Close();//formu kapat
            }

            
        }
    }
}
