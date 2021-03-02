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
    public partial class FmrHome : Form
    {
        public FmrHome()
        {
            InitializeComponent();
        }

        private void clickParaMásInformaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrAcercaDe infoUs = new FmrAcercaDe();
            //el formulario de abre sobre el formulario padre
            infoUs.MdiParent = this;
            infoUs.Show();
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrListaVisualDeUsuario frm = new FmrListaVisualDeUsuario();
            frm.Show();
        }

        public String usuarioEstado;
        private void FmrHome_Load(object sender, EventArgs e)
        {
            label2.Text = usuarioEstado;
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrOperaciones op = new FmrOperaciones();
            op.MdiParent = this;
            op.button1.Visible = false;
            
            op.Show();

        }

        private void restasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrOperaciones op2 = new FmrOperaciones();
            op2.MdiParent = this;
            op2.btnSuma.Visible = false;
           
            op2.Show();
        }
    }
}
