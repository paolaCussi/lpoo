namespace MyCompany
{
    partial class frmUser
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxUsuario = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.timeIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dgdUsuario = new System.Windows.Forms.DataGridView();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lblAnioI = new System.Windows.Forms.Label();
            this.lblAnioF = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgUsu = new System.Windows.Forms.PictureBox();
            this.btnRegEmp = new System.Windows.Forms.Button();
            this.boxUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // boxUsuario
            // 
            this.boxUsuario.Controls.Add(this.btnModificar);
            this.boxUsuario.Controls.Add(this.btnEliminar);
            this.boxUsuario.Controls.Add(this.btnAgregar);
            this.boxUsuario.Controls.Add(this.timeIngreso);
            this.boxUsuario.Controls.Add(this.txtContraseña);
            this.boxUsuario.Controls.Add(this.txtUsuario);
            this.boxUsuario.Controls.Add(this.txtId);
            this.boxUsuario.Controls.Add(this.lblIngreso);
            this.boxUsuario.Controls.Add(this.lblContraseña);
            this.boxUsuario.Controls.Add(this.lblUsuario);
            this.boxUsuario.Controls.Add(this.lblId);
            this.boxUsuario.Location = new System.Drawing.Point(12, 160);
            this.boxUsuario.Name = "boxUsuario";
            this.boxUsuario.Size = new System.Drawing.Size(332, 290);
            this.boxUsuario.TabIndex = 0;
            this.boxUsuario.TabStop = false;
            this.boxUsuario.Text = "Usuario";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnModificar.Location = new System.Drawing.Point(131, 240);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 31);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnEliminar.Location = new System.Drawing.Point(232, 240);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 31);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(18, 240);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 31);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseMnemonic = false;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // timeIngreso
            // 
            this.timeIngreso.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeIngreso.Location = new System.Drawing.Point(116, 168);
            this.timeIngreso.Name = "timeIngreso";
            this.timeIngreso.Size = new System.Drawing.Size(149, 25);
            this.timeIngreso.TabIndex = 8;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(116, 127);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(173, 23);
            this.txtContraseña.TabIndex = 7;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(116, 79);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(173, 23);
            this.txtUsuario.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(116, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(173, 23);
            this.txtId.TabIndex = 5;
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(41, 168);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(61, 16);
            this.lblIngreso.TabIndex = 4;
            this.lblIngreso.Text = "Ingreso";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(15, 131);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(87, 16);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(39, 79);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 16);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(73, 36);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 16);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID";
            // 
            // dgdUsuario
            // 
            this.dgdUsuario.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgdUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdUsuario.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgdUsuario.Location = new System.Drawing.Point(350, 170);
            this.dgdUsuario.Name = "dgdUsuario";
            this.dgdUsuario.ReadOnly = true;
            this.dgdUsuario.RowHeadersWidth = 51;
            this.dgdUsuario.RowTemplate.Height = 24;
            this.dgdUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdUsuario.Size = new System.Drawing.Size(608, 307);
            this.dgdUsuario.TabIndex = 1;
            this.dgdUsuario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdUsuario_CellContentDoubleClick);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(476, 135);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(120, 23);
            this.txt1.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnBuscar.Location = new System.Drawing.Point(854, 129);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 34);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(708, 136);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(118, 23);
            this.txt2.TabIndex = 4;
            // 
            // lblAnioI
            // 
            this.lblAnioI.AutoSize = true;
            this.lblAnioI.Location = new System.Drawing.Point(377, 139);
            this.lblAnioI.Name = "lblAnioI";
            this.lblAnioI.Size = new System.Drawing.Size(100, 16);
            this.lblAnioI.TabIndex = 5;
            this.lblAnioI.Text = "Año de Inicio";
            // 
            // lblAnioF
            // 
            this.lblAnioF.AutoSize = true;
            this.lblAnioF.Location = new System.Drawing.Point(622, 139);
            this.lblAnioF.Name = "lblAnioF";
            this.lblAnioF.Size = new System.Drawing.Size(84, 16);
            this.lblAnioF.TabIndex = 6;
            this.lblAnioF.Text = "Año de Fin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MyCompany.Properties.Resources.Gato4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(128, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 128);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // imgUsu
            // 
            this.imgUsu.BackgroundImage = global::MyCompany.Properties.Resources.Usuario;
            this.imgUsu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgUsu.ErrorImage = null;
            this.imgUsu.InitialImage = null;
            this.imgUsu.Location = new System.Drawing.Point(363, 0);
            this.imgUsu.Name = "imgUsu";
            this.imgUsu.Size = new System.Drawing.Size(514, 179);
            this.imgUsu.TabIndex = 7;
            this.imgUsu.TabStop = false;
            // 
            // btnRegEmp
            // 
            this.btnRegEmp.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegEmp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegEmp.FlatAppearance.BorderSize = 0;
            this.btnRegEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnRegEmp.Location = new System.Drawing.Point(95, 456);
            this.btnRegEmp.Name = "btnRegEmp";
            this.btnRegEmp.Size = new System.Drawing.Size(170, 31);
            this.btnRegEmp.TabIndex = 12;
            this.btnRegEmp.Text = "Registrar Empleados";
            this.btnRegEmp.UseVisualStyleBackColor = false;
            this.btnRegEmp.Click += new System.EventHandler(this.BtnRegEmp_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(970, 490);
            this.Controls.Add(this.btnRegEmp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAnioF);
            this.Controls.Add(this.lblAnioI);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.dgdUsuario);
            this.Controls.Add(this.boxUsuario);
            this.Controls.Add(this.imgUsu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("News706 BT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USUARIOS";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.boxUsuario.ResumeLayout(false);
            this.boxUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox boxUsuario;
        private System.Windows.Forms.DateTimePicker timeIngreso;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgdUsuario;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lblAnioI;
        private System.Windows.Forms.Label lblAnioF;
        private System.Windows.Forms.PictureBox imgUsu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegEmp;
    }
}

