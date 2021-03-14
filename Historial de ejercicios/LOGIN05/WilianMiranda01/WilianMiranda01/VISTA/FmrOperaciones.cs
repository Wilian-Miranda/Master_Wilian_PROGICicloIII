using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WilianMiranda01.VISTA
{
    public partial class FmrOperaciones : Form
    {
        public FmrOperaciones()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                int suma;
                suma = Convert.ToInt32(txtDato1.Text) + Convert.ToInt32(txtDato2.Text);

                txtResultado.Text = suma.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos incorrectos, revise." + "\n"+ ex.ToString());
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int resta;
                resta = Convert.ToInt32(txtDato1.Text) - Convert.ToInt32(txtDato2.Text);

                txtResultado.Text = resta.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos incorrectos, revise." + "\n" + ex.ToString());

            }
        }

        private void FmrOperaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
