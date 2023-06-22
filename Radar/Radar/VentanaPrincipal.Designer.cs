
namespace Radar
{
    partial class VentanaPrincipal
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
			this.btnBuscar = new System.Windows.Forms.Button();
			this.lsbInfracciones = new System.Windows.Forms.ListBox();
			this.tbPatente = new System.Windows.Forms.TextBox();
			this.lbPatente = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnListar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(223, 19);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(126, 40);
			this.btnBuscar.TabIndex = 4;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// lsbInfracciones
			// 
			this.lsbInfracciones.FormattingEnabled = true;
			this.lsbInfracciones.Location = new System.Drawing.Point(12, 85);
			this.lsbInfracciones.Name = "lsbInfracciones";
			this.lsbInfracciones.Size = new System.Drawing.Size(217, 82);
			this.lsbInfracciones.TabIndex = 0;
			this.lsbInfracciones.TabStop = false;
			// 
			// tbPatente
			// 
			this.tbPatente.Location = new System.Drawing.Point(56, 19);
			this.tbPatente.Name = "tbPatente";
			this.tbPatente.Size = new System.Drawing.Size(161, 20);
			this.tbPatente.TabIndex = 3;
			// 
			// lbPatente
			// 
			this.lbPatente.AutoSize = true;
			this.lbPatente.Location = new System.Drawing.Point(6, 33);
			this.lbPatente.Name = "lbPatente";
			this.lbPatente.Size = new System.Drawing.Size(44, 13);
			this.lbPatente.TabIndex = 3;
			this.lbPatente.Text = "Patente";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbPatente);
			this.groupBox1.Controls.Add(this.btnBuscar);
			this.groupBox1.Controls.Add(this.tbPatente);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(355, 67);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(235, 85);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(126, 40);
			this.btnAgregar.TabIndex = 0;
			this.btnAgregar.Text = "Registrar Vehiculo";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnListar
			// 
			this.btnListar.Location = new System.Drawing.Point(235, 128);
			this.btnListar.Name = "btnListar";
			this.btnListar.Size = new System.Drawing.Size(126, 39);
			this.btnListar.TabIndex = 1;
			this.btnListar.Text = "Listar Infractores";
			this.btnListar.UseVisualStyleBackColor = true;
			this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
			// 
			// VentanaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 179);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnListar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.lsbInfracciones);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "VentanaPrincipal";
			this.Text = "Radar";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.ListBox lsbInfracciones;
		private System.Windows.Forms.TextBox tbPatente;
		private System.Windows.Forms.Label lbPatente;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnListar;
	}
}

