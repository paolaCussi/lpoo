using MyCompany.Controller;
using MyCompany.Model;
using MyCompany.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCompany
{
    public partial class frmEmpleado : Form
    {
        EmpleadoModel Empleado = new EmpleadoModel(); 
        public frmEmpleado(EmpleadoModel emp)
        {
            Empleado = emp;
            InitializeComponent();
        }
        private static frmEmpleado Instancia = null;
        public static frmEmpleado obtenerInstancia(EmpleadoModel e)
        {
            if (Instancia == null)
            {
                Instancia = new frmEmpleado(e);
            }
            Instancia.Visible = true;
            return Instancia;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            dgvEmpleado.DataSource = Empleado.obtenerTabla();
            this.boxCargo.DataSource = Empleado.cargarCargos();
        }
        public void limpiarCampos()
        {
            this.txtId.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtEdad.Text = "";
            this.txtSueldo.Text = "";
            this.boxCargo.Text = "";

        }        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleados empleado = new Empleados();
                empleado.id = Int32.Parse(this.txtId.Text);
                empleado.nombre = this.txtNombre.Text;
                empleado.apellido = this.txtApellido.Text;
                empleado.cargo = this.boxCargo.SelectedItem.ToString();
                empleado.edad = Int32.Parse(this.txtEdad.Text);
                empleado.sueldo = double.Parse(this.txtSueldo.Text);
                empleado.FechaIngreso = this.dtIngreso.Value;
                this.dgvEmpleado.DataSource = null;
                this.dgvEmpleado.DataSource = Empleado.Agregar(empleado);
                limpiarCampos();
            }
            catch (Exception io)
            {
                MessageBox.Show("Datos incorrectos " + io.Message, "Atencion",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        
        private void dgvEmpleado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleado != null)
            {
                this.txtId.Text = dgvEmpleado.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtNombre.Text = dgvEmpleado.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txtApellido.Text = dgvEmpleado.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.boxCargo.SelectedItem = dgvEmpleado.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.txtEdad.Text = dgvEmpleado.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.txtSueldo.Text = dgvEmpleado.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.dtIngreso.Text = dgvEmpleado.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            else
            {
                MessageBox.Show("No hay datos en la tabla ", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtId.Text == "")
                {
                    MessageBox.Show("Debe Seleccionar una fila", "Atencion",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.dgvEmpleado.DataSource = null;
                    this.dgvEmpleado.DataSource = Empleado.Eliminar
                        (Empleado.obtenerEmp(Int32.Parse(this.txtId.Text)));
                    limpiarCampos();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleados emp = new Empleados();
                emp.id = Int32.Parse(this.txtId.Text);
                emp.nombre = this.txtNombre.Text;
                emp.apellido = this.txtApellido.Text;
                emp.edad = Int32.Parse(this.txtEdad.Text);
                emp.cargo = this.boxCargo.SelectedItem.ToString();
                emp.sueldo = double.Parse(this.txtSueldo.Text);
                emp.FechaIngreso = this.dtIngreso.Value;
                this.dgvEmpleado.DataSource = null;
                this.dgvEmpleado.DataSource = Empleado.Modificar(emp);
                limpiarCampos();
            }
            catch (Exception io)
            {
                MessageBox.Show("Datos incorrectos " + io.Message, "Atencion",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        private void btnVerEmple_Click(object sender, EventArgs e)
        {
            frmFiltrarEmpleado filtrarEmp = new frmFiltrarEmpleado(Empleado);
            this.Hide();
            filtrarEmp.Show();
        }
    }
}
