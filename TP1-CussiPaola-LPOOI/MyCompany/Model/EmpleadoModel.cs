using MyCompany.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCompany.Model
{
    public class EmpleadoModel
    {
        public DateTime fe;
        public List<Empleados> ListEmp = new List<Empleados>();

        public void CargarTabla()
        {
            Empleados e1 = new Empleados(1, "Soledad", "Cussi", "Programmer", 29, 20500, fe = new DateTime(2013, 12, 02));
            Empleados e2 = new Empleados(2, "Enzo", "Toconas", "Admin", 30, 20500, fe = new DateTime(2016, 12, 02));
            Empleados e3 = new Empleados(3, "Josue", "Careaga", "Programmer", 25, 20500, fe = new DateTime(2014, 12, 02));

            ListEmp.Add(e1);
            ListEmp.Add(e2);
            ListEmp.Add(e3);
        }
        public List<Empleados> obtenerTabla()
        {
            CargarTabla();
            return ListEmp;
        }
        public List<Empleados> Agregar(Empleados emp)
        {
            bool en = false;
            foreach (var empleado in ListEmp)
            {
                if (emp.id != empleado.id)
                {
                    en = true;

                }
            }
            if (en == true)
            {
                ListEmp.Add(emp);

            }
            else
            {
                MessageBox.Show("Ya existe un Empleado con ese ID");

            }

            return ListEmp;
        }
        public List<Empleados> Eliminar(Empleados us)
        {
            ListEmp.Remove(us);
            return ListEmp;
        }

        public List<Empleados> Modificar(Empleados emp)
        {
            bool en = false;
            foreach (var empleado in ListEmp)
            {
                if (emp.id == empleado.id)
                {
                    empleado.nombre = emp.nombre;
                    empleado.apellido = emp.apellido;
                    empleado.cargo = emp.cargo;
                    empleado.edad = emp.edad;
                    empleado.sueldo = emp.sueldo;
                    empleado.FechaIngreso = emp.FechaIngreso;
                    en = true;
                }

            }
            if (en == true)
                MessageBox.Show("Se modifico con exito");
            else
                MessageBox.Show("No puede modificar el ID");
            return ListEmp;
        }
        public Empleados obtenerEmp(int idE)
        {
            Empleados eTemp = new Empleados();
            foreach (var empleado in ListEmp)
            {
                if (empleado.id == idE)
                {
                    eTemp = empleado;
                }
            }
            return eTemp;
        }
        public List<Empleados> buscar(DateTime anioI, DateTime anioF, string cargo)
        {
            List<Empleados> encontrado = new List<Empleados>();
            foreach (Empleados empleado in ListEmp)
            {
                if (empleado.FechaIngreso >= anioI && empleado.FechaIngreso <= anioF && empleado.cargo == cargo)
                {
                    encontrado.Add(empleado);
                }

            }
            return encontrado;
        }
        public List<Empleados> buscarCargo(string cargo)
        {
            List<Empleados> encontrado = new List<Empleados>();
            foreach (Empleados empleado in ListEmp)
            {
                if (empleado.cargo == cargo)
                {
                    encontrado.Add(empleado);
                }

            }
            return encontrado;
        }
        public List<string> cargarCargos()
        {
            HashSet<string> cargos = new HashSet<string>();
            //datos que no se repiten
            cargos.Add("Programmer");
            cargos.Add("Admin");
            cargos.Add("DBA");
            cargos.Add("Designer");
            foreach (Empleados em in ListEmp) 
            
                cargos.Add(em.cargo);
            return cargos.ToList();            
            
        }
        public int promedioEdad(List<Empleados> emp)
        {
            int edad = 0, prom;
            foreach (Empleados em in emp)
            {
                edad = edad + em.edad;
            }
            prom = edad / emp.Count;
            return prom;
        }
    }
}
