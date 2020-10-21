using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Controller
{
    public class Empleados
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cargo { get; set; }
        public int edad { get; set; }
        public double sueldo { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Empleados()
        {

        }
        public Empleados(int id, string name, string ape, string cargo, int edad, double sueldo, DateTime fechaIng)
        {
            this.id = id;
            this.nombre = name;
            this.apellido = ape;
            this.cargo = cargo;
            this.edad = edad;
            this.sueldo = sueldo;
            this.FechaIngreso = fechaIng;
        }
    }
}
