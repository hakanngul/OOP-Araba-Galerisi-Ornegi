using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaGalerisi
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            
            InitializeComponent();
            
        }
        Galeri AG = new Galeri();

        private void btnArabaEkle_Click(object sender, EventArgs e)
        {
            Araba A = new Araba();
            A.Marka = txtMarka.Text.ToString();
            A.Model = Convert.ToInt16(txtModel.Text);
            A.Renk = txtRenk.Text.ToString();

            AG.ArabaEkle(A);
        }

        private void btnArabaListele_Click(object sender, EventArgs e)
        {
            txtListele.Text = AG.ArabaListele();
        }

        private void btnArabaSat_Click(object sender, EventArgs e)
        {

        }
    }
}
