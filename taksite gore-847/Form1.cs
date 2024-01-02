using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taksite_gore_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double tarih = Convert.ToDouble(txtSayi.Text) / Convert.ToDouble(numTaksit.Value);

             for(int i = 0; i < numTaksit.Value; i++)
            {
                MessageBox.Show(i.ToString());
            }
        }
    }
}
