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
    }
}
