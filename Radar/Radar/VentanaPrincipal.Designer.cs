
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
			this.gbBuscar = new System.Windows.Forms.GroupBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnListar = new System.Windows.Forms.Button();
			this.gbPatentes = new System.Windows.Forms.GroupBox();
			this.gbBuscar.SuspendLayout();
			this.gbPatentes.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(258, 19);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(129, 36);
			this.btnBuscar.TabIndex = 6;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// lsbInfracciones
			// 
			this.lsbInfracciones.Font = new System.Drawing.Font("Liberation Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lsbInfracciones.FormattingEnabled = true;
			this.lsbInfracciones.ItemHeight = 12;
			this.lsbInfracciones.Location = new System.Drawing.Point(9, 19);
			this.lsbInfracciones.Name = "lsbInfracciones";
			this.lsbInfracciones.Size = new System.Drawing.Size(243, 76);
			this.lsbInfracciones.TabIndex = 0;
			this.lsbInfracciones.TabStop = false;
			// 
			// tbPatente
			// 
			this.tbPatente.Location = new System.Drawing.Point(56, 28);
			this.tbPatente.Name = "tbPatente";
			this.tbPatente.Size = new System.Drawing.Size(196, 20);
			this.tbPatente.TabIndex = 5;
			// 
			// lbPatente
			// 
			this.lbPatente.AutoSize = true;
			this.lbPatente.Location = new System.Drawing.Point(6, 31);
			this.lbPatente.Name = "lbPatente";
			this.lbPatente.Size = new System.Drawing.Size(44, 13);
			this.lbPatente.TabIndex = 3;
			this.lbPatente.Text = "Patente";
			// 
			// gbBuscar
			// 
			this.gbBuscar.Controls.Add(this.lbPatente);
			this.gbBuscar.Controls.Add(this.btnBuscar);
			this.gbBuscar.Controls.Add(this.tbPatente);
			this.gbBuscar.Location = new System.Drawing.Point(12, 12);
			this.gbBuscar.Name = "gbBuscar";
			this.gbBuscar.Size = new System.Drawing.Size(393, 68);
			this.gbBuscar.TabIndex = 4;
			this.gbBuscar.TabStop = false;
			this.gbBuscar.Text = "Buscar Patente";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(258, 19);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(129, 36);
			this.btnAgregar.TabIndex = 1;
			this.btnAgregar.Text = "Registrar Vehiculo";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnListar
			// 
			this.btnListar.Location = new System.Drawing.Point(258, 59);
			this.btnListar.Name = "btnListar";
			this.btnListar.Size = new System.Drawing.Size(129, 36);
			this.btnListar.TabIndex = 2;
			this.btnListar.Text = "Listar Infractores";
			this.btnListar.UseVisualStyleBackColor = true;
			this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
			// 
			// gbPatentes
			// 
			this.gbPatentes.Controls.Add(this.lsbInfracciones);
			this.gbPatentes.Controls.Add(this.btnAgregar);
			this.gbPatentes.Controls.Add(this.btnListar);
			this.gbPatentes.Location = new System.Drawing.Point(12, 86);
			this.gbPatentes.Name = "gbPatentes";
			this.gbPatentes.Size = new System.Drawing.Size(393, 105);
			this.gbPatentes.TabIndex = 0;
			this.gbPatentes.TabStop = false;
			this.gbPatentes.Text = "Patentes";
			// 
			// VentanaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 203);
			this.Controls.Add(this.gbPatentes);
			this.Controls.Add(this.gbBuscar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "VentanaPrincipal";
			this.Text = "Radar";
			this.gbBuscar.ResumeLayout(false);
			this.gbBuscar.PerformLayout();
			this.gbPatentes.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.ListBox lsbInfracciones;
		private System.Windows.Forms.TextBox tbPatente;
		private System.Windows.Forms.Label lbPatente;
		private System.Windows.Forms.GroupBox gbBuscar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnListar;
		private System.Windows.Forms.GroupBox gbPatentes;
	}
}

