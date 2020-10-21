using MyCompany;
using MyCompany.Controller;
using MyCompany.Model;
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
    public partial class frmUser : Form
    {
        UserModel Usuarios = new UserModel();
        EmpleadoModel empleado = new EmpleadoModel();
        public frmUser()
        {
            InitializeComponent();

        }
        
        private static frmUser Instancia = null;

        public static frmUser ObtenerInstancia()
        {

            if (Instancia == null)
            {
                Instancia = new frmUser();

            }
            return Instancia;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario us = new Usuario();
                us.id = Int32.Parse(this.txtId.Text);
                us.nUsuario = this.txtUsuario.Text;
                us.Contrasenia = this.txtContraseña.Text;
                us.FechaIngreso = this.timeIngreso.Value;
                this.dgdUsuario.DataSource = null;
                this.dgdUsuario.DataSource = Usuarios.AgregarUsuario(us);
                limpiarCampos();
            }
            catch (Exception io)
            {
                MessageBox.Show("Datos incorrectos " + io.Message, "Atencion",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
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
                    this.dgdUsuario.DataSource = null;
                    this.dgdUsuario.DataSource = Usuarios.EliminarUsuario
                        (Usuarios.obtenerUsuario(Int32.Parse(this.txtId.Text)));
                    limpiarCampos();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgdUsuario.DataSource = null;
                dgdUsuario.DataSource = Usuarios.buscarUsuario(
                    Int32.Parse(txt1.Text), Int32.Parse(txt2.Text));
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void limpiarCampos()
        {
            this.txtId.Text = "";
            this.txtUsuario.Text = "";
            this.txtContraseña.Text = "";
        }

        private void dgdUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgdUsuario != null)
            {
                this.txtId.Text = dgdUsuario.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtUsuario.Text = dgdUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txtContraseña.Text = dgdUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.timeIngreso.Text = dgdUsuario.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("No hay datos en la tabla ", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario us = new Usuario();
                us.id = Int32.Parse(this.txtId.Text);
                us.nUsuario = this.txtUsuario.Text;
                us.Contrasenia = this.txtContraseña.Text;
                us.FechaIngreso = this.timeIngreso.Value;
                this.dgdUsuario.DataSource = null;
                this.dgdUsuario.DataSource = Usuarios.ModificarUsuario(us);
                limpiarCampos();
            }
            catch (Exception io)
            {
                MessageBox.Show("Datos incorrectos " + io.Message, "Atencion",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            dgdUsuario.DataSource = Usuarios.obtenerTabla();
        }

        private void BtnRegEmp_Click(object sender, EventArgs e)
        {
            frmEmpleado emp = new frmEmpleado(empleado);
            this.Hide();
            emp.Show();

        }
    }
}

