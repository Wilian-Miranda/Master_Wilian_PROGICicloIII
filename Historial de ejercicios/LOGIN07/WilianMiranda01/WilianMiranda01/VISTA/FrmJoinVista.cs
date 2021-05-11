using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WilianMiranda01.MODEL;

namespace WilianMiranda01.VISTA
{
    public partial class FrmJoinVista : Form
    {
        public FrmJoinVista()
        {
            InitializeComponent();
        }

        //Buscador, cuando se introduzca u caracter se hará una busqueda
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            load();
        }

        private void FrmJoinVista_Load(object sender, EventArgs e)
        {
            load();
        }

        //Consulta con linq
        private void load()
        {
            dataGridView1.Rows.Clear();
            using (programacionEntities db = new programacionEntities())
            {
                //acronimo //inner join
                var consulta = (from usuario in db.UserList
                                from tipo in db.TypeOfUser

                                where usuario.FK_IdTypeUser == tipo.IdTypeOfUser && usuario.NombreUsuario.Contains(textBox1.Text)

                                //entidades a enviar a la vista
                                select new
                                {
                                    usuario.NombreUsuario,
                                    usuario.TypeOfUser
                                }
                                ).ToList();

                foreach (var i in consulta)
                {
                    dataGridView1.Rows.Add(i.NombreUsuario, i.TypeOfUser);
                }


            }
        }
    }
}
