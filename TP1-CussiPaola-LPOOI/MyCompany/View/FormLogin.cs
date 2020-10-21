using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MyCompany;


namespace MyCompany
{
    public partial class frmLogin : Form
    {
        UserModel Usuarios = new UserModel();
        public Usuario usuarioLogin = new Usuario();
        public frmLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparm, int lparam);

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "USUARIO")
            {
                this.txtUsuario.Text = "";
                this.txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "")
            {
                this.txtUsuario.Text = "USUARIO";
                this.txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (this.txtClave.Text == "CONTRASEÑA")
            {
                this.txtClave.Text = "";
                this.txtClave.ForeColor = Color.LightGray;
                this.txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "")
            {
                this.txtClave.Text = "CONTRASENIA";
                this.txtClave.ForeColor = Color.DimGray;
                this.txtClave.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true & this.txtClave.Text != "CONTRASENIA")
            {
                this.txtClave.UseSystemPasswordChar = false;
            }
            else {
                this.txtClave.UseSystemPasswordChar = true;
            }
        }      

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (Usuarios.validarUsuario(this.txtUsuario.Text, this.txtClave.Text))
            {
                frmUser frm = frmUser.ObtenerInstancia();
                frm.Show();
                usuarioLogin = Usuarios.encontrarUsuario(txtUsuario.Text,txtClave.Text);
                this.DialogResult = DialogResult.OK;                
            }
            else
            {
                this.lblError.Visible = true;
                this.lblError.Text = "Usuario o Contraseña Incorrectos";
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           Usuarios.CargarTabla();
        }

    }
        

        
    
}
