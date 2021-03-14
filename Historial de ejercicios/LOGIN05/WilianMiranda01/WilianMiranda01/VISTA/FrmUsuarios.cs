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
            Actualizar();
            Limpiar();
        }
        void Actualizar()
        {
            dtgListaUsuarios.Rows.Clear();
            using (programacionEntities db = new programacionEntities())
            {
                //ToList() devuelve una lista|| es igual a Select * from usuarios
                var Lista = db.UserList.ToList();

                foreach (var iteracion in Lista)
                {
                    //aqui ya se han separado los arreglos
                    dtgListaUsuarios.Rows.Add(iteracion.Id, iteracion.NombreUsuario, 
                        iteracion.Apellido, iteracion.Edad, iteracion.Pass);

                }
            }
        }
        void Limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtContraseña.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btnAgregarRegistro.Visible = true;
            btnAgregar.Visible = false;
            btnAtras.Visible = true;

            btnActualizar.Visible = false;
            btnEliminar.Visible = false;

            panel1.Enabled = true;

            txtId.Enabled = false;
            lblId.Enabled = false;
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;

            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtEdad.Enabled = false;
            txtContraseña.Enabled = false;

            lblNombre.Enabled = false;
            lblApellido.Enabled = false;
            lblEdad.Enabled = false;
            lblPass.Enabled = false;

            btnActualizar.Visible = false;
            btnAgregar.Visible = false;
            btnEliminar.Visible = false;
            btnAtras.Visible = true;
            btnEliminarRegistros.Visible = true;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            btnAgregar.Visible = false;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;

            btnActualizarRegistros.Visible = true;
            btnAtras.Visible = true;

            panel1.Enabled = true;

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Limpiar();

            btnAtras.Visible = false;

            btnActualizar.Visible = true;
            btnEliminar.Visible = true;
            btnAgregar.Visible = true;


            btnAgregarRegistro.Visible = false;
            btnEliminarRegistros.Visible = false;
            btnActualizarRegistros.Visible = false;

            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtEdad.Enabled = true;
            txtContraseña.Enabled = true;

            lblId.Enabled = true;
            lblNombre.Enabled = true;
            lblApellido.Enabled = true;
            lblEdad.Enabled = true;
            lblPass.Enabled = true;

            panel1.Enabled = false;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {

            if ((txtApellido.Text == "" || txtNombre.Text == "")
                        || (txtEdad.Text == "" || txtContraseña.Text == ""))
            {
                MessageBox.Show("Información incompleta");
            }
            else
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

                        Limpiar();

                    }
                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.ToString());
                }
                Actualizar();

            }
        }

        private void btnActualizarRegistros_Click(object sender, EventArgs e)
        {
            using (programacionEntities db = new programacionEntities())
            {
                if ((txtApellido.Text == "" || txtNombre.Text == "")
                || (txtEdad.Text == "" || txtContraseña.Text == "")
                || (txtId.Text == ""))
                {
                    MessageBox.Show("Información incompleta");
                }
                else
                {
                    try
                    {

                        int update = Convert.ToInt32(txtId.Text);
                        UserList userListActualizar = db.UserList.Where(x => x.Id == update).Select(x => x).FirstOrDefault();
                        userListActualizar.NombreUsuario = txtNombre.Text;
                        userListActualizar.Apellido = txtApellido.Text;
                        userListActualizar.Edad = Convert.ToInt32(txtEdad.Text);
                        userListActualizar.Pass = txtContraseña.Text;
                        db.SaveChanges();


                        MessageBox.Show("Actualizado");

                        Limpiar();


                    }
                    catch (Exception EX)
                    {

                        MessageBox.Show(EX.ToString());
                    }
                    Actualizar();
                }
            }
        }

        private void btnEliminarRegistros_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Información incompleta");
            }
            else
            {
                try
                {
                    using (programacionEntities db = new programacionEntities())
                    {
                        int eliminar = Convert.ToInt32(txtId.Text);
                        UserList userListBorrar = db.UserList.Where(x => x.Id == eliminar).Select(x => x).FirstOrDefault();
                        //userListBorrar =  db.UserList.Find(eliminar);
                        db.UserList.Remove(userListBorrar);
                        db.SaveChanges();

                        MessageBox.Show("Deleted");
                        Limpiar();


                    }
                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.ToString());

                }
            }
            Actualizar();

        }

        private void FrmUsuarios_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dtgListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                String Id = dtgListaUsuarios.CurrentRow.Cells[0].Value.ToString();
                String Nombre = dtgListaUsuarios.CurrentRow.Cells[1].Value.ToString();
                String Apellido = dtgListaUsuarios.CurrentRow.Cells[2].Value.ToString();
                String Edad = dtgListaUsuarios.CurrentRow.Cells[3].Value.ToString();
                String Pass = dtgListaUsuarios.CurrentRow.Cells[4].Value.ToString();

                txtId.Text = Id;
                txtNombre.Text = Nombre;
                txtApellido.Text = Apellido;
                txtEdad.Text = Edad;
                txtContraseña.Text = Pass;
            

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
    
}
