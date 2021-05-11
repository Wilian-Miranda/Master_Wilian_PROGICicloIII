using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WilianMiranda01.MODEL;

namespace WilianMiranda01.DAO
{
    class ClsDUserList
    {
        #region Cargar_Datos
        public List<UserList> cargarDatosUserList()
        {
            List<UserList> Lista;

            using (programacionEntities db = new programacionEntities())
            {
                //ToList() devuelve una lista|| es igual a Select * from usuarios
                Lista = db.UserList.ToList();

            }

            return Lista;
        }
        #endregion

        #region GuardarUsuarios
        //public void guardarDatosUserList(String nombre, String apellido, int edad, String pass)
        //{
        //    try
        //    {
        //        using (programacionEntities db = new programacionEntities())
        //        {
        //            UserList userList = new UserList();

        //            userList.NombreUsuario = nombre;
        //            userList.Apellido = apellido;
        //            userList.Edad = edad;
        //            userList.Pass = pass;
        //            db.UserList.Add(userList);
        //            db.SaveChanges();

        //            System.Windows.Forms.MessageBox.Show("Save");

        //        }
        //    }
        //    catch (Exception EX)
        //    {

        //        MessageBox.Show(EX.ToString());
        //    }
        //}
        public void GuardarUsuarios(UserList user)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    UserList userList = new UserList();

                    userList.NombreUsuario = user.NombreUsuario;
                    userList.Apellido = user.Apellido;
                    userList.Edad = user.Edad;
                    userList.Pass = user.Pass;
                    db.UserList.Add(userList);
                    db.SaveChanges();

                    MessageBox.Show("Guardado");


                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.ToString());
            }
        }

        #endregion

        #region Borrar_Usuarios
        public void borrarUsuario(int ID)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    UserList userListBorrar = db.UserList.Where(x => x.Id == ID).Select(x => x).FirstOrDefault();

                    db.UserList.Remove(userListBorrar);
                    db.SaveChanges();

                    MessageBox.Show("Borrado");


                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.ToString());
            }
        }
        #endregion

        #region Actualizar_Usuarios
        public void actualizarUsuario(UserList user)
        {
            using (programacionEntities db = new programacionEntities())
            {
                try
                {

                    int update = user.Id;
                    UserList userListActualizar = db.UserList.Where(x => x.Id == update).Select(x => x).FirstOrDefault();
                    userListActualizar.NombreUsuario = user.NombreUsuario;
                    userListActualizar.Apellido = user.Apellido;
                    userListActualizar.Edad = user.Edad;
                    userListActualizar.Pass = user.Pass;
                    db.SaveChanges();


                    MessageBox.Show("Actualizado");


                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.ToString());
                }
            }

        }
        #endregion

    }
}
