namespace MyCompany.View
{
    partial class frmFiltrarEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltrarEmpleado));
            this.dgvFiltrarEmp = new System.Windows.Forms.DataGridView();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblSelecCargo = new System.Windows.Forms.Label();
            this.boxSelecCargo = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cbFecha = new System.Windows.Forms.CheckBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.lblEdadProm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrarEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFiltrarEmp
            // 
            this.dgvFiltrarEmp.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvFiltrarEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltrarEmp.Location = new System.Drawing.Point(261, 116);
            this.dgvFiltrarEmp.Name = "dgvFiltrarEmp";
            this.dgvFiltrarEmp.RowHeadersWidth = 51;
            this.dgvFiltrarEmp.RowTemplate.Height = 24;
            this.dgvFiltrarEmp.Size = new System.Drawing.Size(807, 322);
            this.dgvFiltrarEmp.TabIndex = 0;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("News701 BT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(32, 27);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(182, 17);
            this.lblFiltro.TabIndex = 1;
            this.lblFiltro.Text = "Filtro: Combo Activado ";
            // 
            // lblSelecCargo
            // 
            this.lblSelecCargo.AutoSize = true;
            this.lblSelecCargo.Font = new System.Drawing.Font("News701 BT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecCargo.Location = new System.Drawing.Point(264, 61);
            this.lblSelecCargo.Name = "lblSelecCargo";
            this.lblSelecCargo.Size = new System.Drawing.Size(159, 17);
            this.lblSelecCargo.TabIndex = 2;
            this.lblSelecCargo.Text = "Seleccione un Cargo:";
            // 
            // boxSelecCargo
            // 
            this.boxSelecCargo.FormattingEnabled = true;
            this.boxSelecCargo.Location = new System.Drawing.Point(447, 57);
            this.boxSelecCargo.Name = "boxSelecCargo";
            this.boxSelecCargo.Size = new System.Drawing.Size(174, 24);
            this.boxSelecCargo.TabIndex = 3;
            this.boxSelecCargo.Text = "Programmer";
            
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnFiltrar.Font = new System.Drawing.Font("News701 BT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(700, 52);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(84, 33);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbFecha
            // 
            this.cbFecha.AutoSize = true;
            this.cbFecha.Font = new System.Drawing.Font("News701 BT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFecha.Location = new System.Drawing.Point(35, 81);
            this.cbFecha.Name = "cbFecha";
            this.cbFecha.Size = new System.Drawing.Size(73, 21);
            this.cbFecha.TabIndex = 5;
            this.cbFecha.Text = "Fecha";
            this.cbFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cbFecha.UseVisualStyleBackColor = true;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(35, 116);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(140, 23);
            this.dtInicio.TabIndex = 6;
            // 
            // dtFin
            // 
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFin.Location = new System.Drawing.Point(35, 159);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(140, 23);
            this.dtFin.TabIndex = 7;
            // 
            // lblEdadProm
            // 
            this.lblEdadProm.AutoSize = true;
            this.lblEdadProm.Location = new System.Drawing.Point(12, 222);
            this.lblEdadProm.Name = "lblEdadProm";
            this.lblEdadProm.Size = new System.Drawing.Size(124, 17);
            this.lblEdadProm.TabIndex = 8;
            this.lblEdadProm.Text = "Edad Promedio:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(42, 23);
            this.textBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MyCompany.Properties.Resources.Gato1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(47, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 153);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmFiltrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1077, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEdadProm);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.cbFecha);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.boxSelecCargo);
            this.Controls.Add(this.lblSelecCargo);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.dgvFiltrarEmp);
            this.Font = new System.Drawing.Font("News701 BT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFiltrarEmpleado";
            this.Text = "Filtrar Empleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFiltrarEmpleado_FormClosing);
            this.Load += new System.EventHandler(this.frmFiltrarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrarEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFiltrarEmp;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblSelecCargo;
        private System.Windows.Forms.ComboBox boxSelecCargo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.CheckBox cbFecha;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Label lblEdadProm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}