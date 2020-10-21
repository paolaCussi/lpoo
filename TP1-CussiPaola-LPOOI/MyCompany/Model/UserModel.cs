using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCompany;

namespace MyCompany
{
    public class UserModel
    {
        public DateTime fe;
        public List<Usuario> Usuarios = new List<Usuario>();

        public void CargarTabla()
        {
            Usuario u1 = new Usuario(1, "Soledad", "sole1234", fe = new DateTime(2013, 12, 02));
            Usuario u2 = new Usuario(2, "Josefina", "josefina1234", fe = new DateTime(2020, 12, 02));
            Usuario u3 = new Usuario(3, "Enzo", "enzo1234", fe = new DateTime(2017, 12, 02));

            Usuarios.Add(u1);
            Usuarios.Add(u2);
            Usuarios.Add(u3);
        }
        public List<Usuario> obtenerTabla()
        {
            CargarTabla();
            return Usuarios;
        }
        public List<Usuario> AgregarUsuario(Usuario us)
        {
            bool en = false;
            foreach(var usu in Usuarios)
            {
                if (us.id != usu.id)
                {
                    en = true;
                    
                }                               
            }
            if (en==true)
            {
                Usuarios.Add(us);

            }
            else
            {
                MessageBox.Show("Ya existe un usuario con ese ID");

            }

            return Usuarios;
        }
        public List<Usuario> EliminarUsuario(Usuario us)
        {
            Usuarios.Remove(us);
            return Usuarios;
        }

        public List<Usuario> ModificarUsuario(Usuario us) 
        {
            bool en = false;
            foreach (var usu in Usuarios)
            {
                if (us.id == usu.id)
                {
                    usu.nUsuario = us.nUsuario;
                    usu.Contrasenia = us.Contrasenia;
                    usu.FechaIngreso = us.FechaIngreso;
                    en = true;
                }      
                
            }
            if (en == true)
                MessageBox.Show("Se modifico con exito");
            else
                MessageBox.Show("No puede modificar el ID");
            return Usuarios;
        }
        public Usuario obtenerUsuario(int idU)
        {
            Usuario uTemp = new Usuario();
            foreach (var us in Usuarios)
            {
                if (us.id == idU)
                {
                    uTemp = us;
                }
            }
            return uTemp;
        }
        public List<Usuario> buscarUsuario(int anioI, int anioF)
        {
            List<Usuario> encontrado = new List<Usuario>();
            foreach (Usuario us in Usuarios)
            {
                if (us.FechaIngreso.Year >= anioI && us.FechaIngreso.Year <= anioF)
                {
                    encontrado.Add(us);
                }

            }
            return encontrado;
        }

        public bool validarUsuario(string usuario, string clave) {
            bool usTem = false;
            foreach (var us in Usuarios) 
            {
                if (us.nUsuario == usuario & us.Contrasenia == clave)
                {
                    usTem = true;
                }
                        
             }
            return usTem;
        }
        public Usuario encontrarUsuario(string usuario, string clave)
        {
            foreach (var us in Usuarios)
            {
                if (us.nUsuario == usuario & us.Contrasenia == clave)
                {
                    return us;
                }
            }
            return null;
        }

    }

}
