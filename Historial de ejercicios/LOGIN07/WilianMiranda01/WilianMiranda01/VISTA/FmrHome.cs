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
            FmrAcercaDe info = new FmrAcercaDe();

            info.MdiParent = this;
            info.FormBorderStyle = FormBorderStyle.None;
            info.Dock = DockStyle.Fill;
            info.BringToFront();
            info.Show();

        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrListaVisualDeUsuario frm = new FmrListaVisualDeUsuario();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
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
            op.FormBorderStyle = FormBorderStyle.None;
            op.Dock = DockStyle.Fill;
            op.BringToFront();
            op.button1.Visible = false;
            
            op.Show();

        }

        private void restasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrOperaciones op2 = new FmrOperaciones();
            op2.MdiParent = this;
            op2.FormBorderStyle = FormBorderStyle.None;
            op2.Dock = DockStyle.Fill;
            op2.btnSuma.Visible = false;

            op2.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mATEMÁTICASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmuser = new FrmUsuarios();
            frmuser.MdiParent = this;
            frmuser.FormBorderStyle = FormBorderStyle.None;
            frmuser.Dock = DockStyle.Fill;
            frmuser.BringToFront();
            frmuser.Show();


        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #region método para mostrar los formularios en el panel

        //Declarando variable para almacenar el formulario activo
        //private Form formularioActivo = null;
        //public void mostrarFormularios(Form formularioHijo)
        //{
        //    if (formularioActivo != null)
        //    {
        //        //Si existe un formulario abierto se cierra
        //        formularioActivo.Close();
        //        //Se almacena el formulario activo en la variable formularioActivo, y se cierra si se habre otro formulario.
        //        formularioActivo = formularioHijo;
        //        //El formularioHijo se comportará como un control
        //        formularioHijo.TopLevel = false;
        //        //Quitamos el borde del formulario
        //        formularioHijo.FormBorderStyle = FormBorderStyle.None;
        //        //LLenamos todo el panel Contenedor utilizando la propiedad Dock
        //        formularioHijo.Dock = DockStyle.Fill;

        //        //Se agrega el formulario o la lista de controles del panel contenedor
        //        pnlContenedor.Controls.Add(formularioHijo);
        //        //se asocia el formulario con el panel contenedor
        //        pnlContenedor.Tag = formularioHijo;

        //        //Si hay un logo en el panel Contenedor se trae el formulario al frente
        //        formularioHijo.BringToFront();

        //        //Mostrar el formulario hijo
        //        formularioHijo.Show();


        //    }
        //}
        #endregion
    }
}
