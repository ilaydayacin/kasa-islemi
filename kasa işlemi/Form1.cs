using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasa_işlemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            double tutar=Convert.ToDouble(txtOde.Text);

            if (rb2.Checked==true || rb3.Checked == true)
            {
                tutar = tutar + (tutar * 5)/tutar;
            }
            if (rb4.Checked==true || rb5.Checked == true)
            {
                tutar = tutar + (tutar * 10)/tutar;
            }
            lblBorc.Text=("Borcunuz: " + tutar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
