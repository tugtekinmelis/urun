using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ürün_satısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int fiyat, miktar, tutar;

            fiyat = Convert.ToInt32(txtFiyat.Text);
            miktar = Convert.ToInt32(txtMiktar.Text);

            tutar = fiyat * miktar;

            lblTutar.Text = "Tutar:" + tutar.ToString();
        }
    }
}
