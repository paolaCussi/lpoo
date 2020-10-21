using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    public class Usuario
    {
        
            public int id { get; set; }
            public string nUsuario { get; set; }
            public string Contrasenia { get; set; }
            public DateTime FechaIngreso { get; set; }

            public Usuario()
            {

            }
            public Usuario(int id, string user, string clave, DateTime fechaIng)
            {
                this.id = id;
                this.nUsuario = user;
                this.Contrasenia = clave;
                this.FechaIngreso = fechaIng;
            }
        
    }
}
