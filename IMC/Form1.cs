using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMC
{
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();
        }

        private void rbnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnMasculino.Checked)
            {
                try
                {
                    double altura = Convert.ToDouble(txtAltura.Text);
                    double pesoIdeal = 72.7 * altura - 58;
                    lblPesoIdeal.Text = pesoIdeal.ToString("N");
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não esqueça da altura");
                }
            }
        }

        private void rbnFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnFeminino.Checked)
            {
                try
                {
                    double altura = Convert.ToDouble(txtAltura.Text);
                    double pesoIdeal = 62.1 * altura - 44.7;
                    lblPesoIdeal.Text = pesoIdeal.ToString("N");
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não esqueça da altura");
                }
            }
        }
    }
}
