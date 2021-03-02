using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WilianMiranda01.DAO;

namespace WilianMiranda01.VISTA
{
    public partial class FmrListaVisualDeUsuario : Form
    {
        public FmrListaVisualDeUsuario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FmrListaVisualDeUsuario_Load(object sender, EventArgs e)
        {
            ClsListaUsuarios cls = new ClsListaUsuarios();
            foreach (var iteracion in cls.user)
            {
                dataGridView1.Rows.Add(iteracion.ToString());
            }

        }
    }
}
