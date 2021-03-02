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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {

                    UserList userList = new UserList();

                    userList.NombreUsuario = txtNombre.Text;
                    userList.Apellido = txtApellido.Text;
                    userList.Edad = Convert.ToInt32(txtEdad.Text);
                    userList.Pass = txtContraseña.Text;
                    db.UserList.Add(userList);
                    db.SaveChanges();

                    MessageBox.Show("Save");

                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int eliminar = Convert.ToInt32(txtId.Text);
                    UserList userListBorrar = new UserList();
                    userListBorrar =  db.UserList.Find(eliminar);
                    db.UserList.Remove(userListBorrar);
                    db.SaveChanges();

                    MessageBox.Show("Deleted");

                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.ToString());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
