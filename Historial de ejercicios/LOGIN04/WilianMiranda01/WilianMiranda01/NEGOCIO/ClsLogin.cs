using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WilianMiranda01.DAO;
using WilianMiranda01.DOMINIO;
using WilianMiranda01.MODEL;

namespace WilianMiranda01.NEGOCIO
{
    class ClsLogin
    {
        ClsListaUsuarios cls = new ClsListaUsuarios();

        //EntLogin login, EntRegistroUsuario access
        public Boolean VerificarUsuario(EntLogin login)
        {
            Boolean a = false;

            //iterando todos los elementos de registro de usuarios
            //access.UsuarioRegistro.Length
            for (int i = 0; i < cls.user.Length; i++)
            {
                /*se compara si el usuario almacenado en la matriz UsuarioRegistro
                 es igual al usuario ingresado en el login en el login 
                */
                if (login.Usuario.Equals(cls.user[i]))
                {
                    /*Si la comparacion del usuario es correcta se compara si 
                     el contraseña almacenada en la matriz PasswordRegistro
                     es igual ala contraseña ingresada en el login 
                    */
                    if (login.Password.Equals(cls.pass[i]))
                    {
                        a = true;
                    }

                }
            }

            return a;
        
        }
    }
}
