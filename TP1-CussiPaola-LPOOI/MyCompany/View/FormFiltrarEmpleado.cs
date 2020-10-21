using MyCompany.Controller;
using MyCompany.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCompany.View
{
    public partial class frmFiltrarEmpleado : Form
    {
        EmpleadoModel Empleado = new EmpleadoModel();
        public frmFiltrarEmpleado(EmpleadoModel emp)
        {
            Empleado = emp;
            InitializeComponent();   
            

        }

        private void volver(object sender, EventArgs e)
        {
            frmEmpleado.obtenerInstancia(Empleado);
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            lblFiltro.Text = "Filtro activado: ";
            try
            {
                List<Empleados> emp = new List<Empleados>();
                
                dgvFiltrarEmp.DataSource = null;
                lblFiltro.Text += boxSelecCargo.SelectedItem;                
                emp= Empleado.buscarCargo(boxSelecCargo.SelectedItem.ToString());                
                
                if (this.cbFecha.Checked == true)
                {
                    
                    emp = Empleado.buscar(dtInicio.Value,dtFin.Value, boxSelecCargo.SelectedItem.ToString()); 

                    
                }
               dgvFiltrarEmp.DataSource = emp;
                this.textBox1.Text = Empleado.promedioEdad(emp).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontraron registros", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        }

        private void frmFiltrarEmpleado_Load(object sender, EventArgs e)
        {
            this.dgvFiltrarEmp.DataSource = Empleado.ListEmp;
            this.FormClosed += new FormClosedEventHandler(volver);
            this.boxSelecCargo.DataSource =  Empleado.cargarCargos();
        }

        private void frmFiltrarEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
