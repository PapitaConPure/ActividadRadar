
namespace Radar {
	partial class VentanaInfraccion {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.gbDatosVehiculo = new System.Windows.Forms.GroupBox();
			this.lbVelocidad = new System.Windows.Forms.Label();
			this.nudVelocidad = new System.Windows.Forms.NumericUpDown();
			this.tbPatente = new System.Windows.Forms.TextBox();
			this.lbPatente = new System.Windows.Forms.Label();
			this.gbTipoVehiculo = new System.Windows.Forms.GroupBox();
			this.rbCivil = new System.Windows.Forms.RadioButton();
			this.rbOficial = new System.Windows.Forms.RadioButton();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.gbDatosVehiculo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudVelocidad)).BeginInit();
			this.gbTipoVehiculo.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbDatosVehiculo
			// 
			this.gbDatosVehiculo.Controls.Add(this.lbVelocidad);
			this.gbDatosVehiculo.Controls.Add(this.nudVelocidad);
			this.gbDatosVehiculo.Controls.Add(this.tbPatente);
			this.gbDatosVehiculo.Controls.Add(this.lbPatente);
			this.gbDatosVehiculo.Location = new System.Drawing.Point(13, 13);
			this.gbDatosVehiculo.Name = "gbDatosVehiculo";
			this.gbDatosVehiculo.Size = new System.Drawing.Size(173, 74);
			this.gbDatosVehiculo.TabIndex = 0;
			this.gbDatosVehiculo.TabStop = false;
			this.gbDatosVehiculo.Text = "Datos del Vehículo";
			// 
			// lbVelocidad
			// 
			this.lbVelocidad.AutoSize = true;
			this.lbVelocidad.Location = new System.Drawing.Point(6, 47);
			this.lbVelocidad.Name = "lbVelocidad";
			this.lbVelocidad.Size = new System.Drawing.Size(88, 13);
			this.lbVelocidad.TabIndex = 3;
			this.lbVelocidad.Text = "Velocidad (km/h)";
			// 
			// nudVelocidad
			// 
			this.nudVelocidad.DecimalPlaces = 2;
			this.nudVelocidad.Location = new System.Drawing.Point(100, 45);
			this.nudVelocidad.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.nudVelocidad.Name = "nudVelocidad";
			this.nudVelocidad.Size = new System.Drawing.Size(67, 20);
			this.nudVelocidad.TabIndex = 1;
			this.nudVelocidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudVelocidad_KeyUp);
			// 
			// tbPatente
			// 
			this.tbPatente.Location = new System.Drawing.Point(100, 19);
			this.tbPatente.Name = "tbPatente";
			this.tbPatente.Size = new System.Drawing.Size(67, 20);
			this.tbPatente.TabIndex = 0;
			this.tbPatente.TextChanged += new System.EventHandler(this.tbPatente_TextChanged);
			// 
			// lbPatente
			// 
			this.lbPatente.AutoSize = true;
			this.lbPatente.Location = new System.Drawing.Point(6, 22);
			this.lbPatente.Name = "lbPatente";
			this.lbPatente.Size = new System.Drawing.Size(44, 13);
			this.lbPatente.TabIndex = 0;
			this.lbPatente.Text = "Patente";
			// 
			// gbTipoVehiculo
			// 
			this.gbTipoVehiculo.Controls.Add(this.rbCivil);
			this.gbTipoVehiculo.Controls.Add(this.rbOficial);
			this.gbTipoVehiculo.Location = new System.Drawing.Point(13, 92);
			this.gbTipoVehiculo.Name = "gbTipoVehiculo";
			this.gbTipoVehiculo.Size = new System.Drawing.Size(173, 69);
			this.gbTipoVehiculo.TabIndex = 1;
			this.gbTipoVehiculo.TabStop = false;
			this.gbTipoVehiculo.Text = "Tipo de Vehículo";
			// 
			// rbCivil
			// 
			this.rbCivil.AutoSize = true;
			this.rbCivil.Checked = true;
			this.rbCivil.Location = new System.Drawing.Point(6, 42);
			this.rbCivil.Name = "rbCivil";
			this.rbCivil.Size = new System.Drawing.Size(89, 17);
			this.rbCivil.TabIndex = 3;
			this.rbCivil.TabStop = true;
			this.rbCivil.Text = "Vehículo civil";
			this.rbCivil.UseVisualStyleBackColor = true;
			// 
			// rbOficial
			// 
			this.rbOficial.AutoSize = true;
			this.rbOficial.Location = new System.Drawing.Point(6, 19);
			this.rbOficial.Name = "rbOficial";
			this.rbOficial.Size = new System.Drawing.Size(98, 17);
			this.rbOficial.TabIndex = 2;
			this.rbOficial.Text = "Vehículo oficial";
			this.rbOficial.UseVisualStyleBackColor = true;
			// 
			// btnAceptar
			// 
			this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAceptar.Enabled = false;
			this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnAceptar.Location = new System.Drawing.Point(12, 167);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(82, 34);
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			// 
			// btnCancelar
			// 
			this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnCancelar.Location = new System.Drawing.Point(104, 167);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(82, 34);
			this.btnCancelar.TabIndex = 5;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// VentanaInfraccion
			// 
			this.AcceptButton = this.btnAceptar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancelar;
			this.ClientSize = new System.Drawing.Size(190, 209);
			this.ControlBox = false;
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.gbTipoVehiculo);
			this.Controls.Add(this.gbDatosVehiculo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "VentanaInfraccion";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Datos del Vehículo";
			this.gbDatosVehiculo.ResumeLayout(false);
			this.gbDatosVehiculo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudVelocidad)).EndInit();
			this.gbTipoVehiculo.ResumeLayout(false);
			this.gbTipoVehiculo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbDatosVehiculo;
		private System.Windows.Forms.GroupBox gbTipoVehiculo;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label lbVelocidad;
		private System.Windows.Forms.Label lbPatente;
		public System.Windows.Forms.NumericUpDown nudVelocidad;
		public System.Windows.Forms.TextBox tbPatente;
		public System.Windows.Forms.RadioButton rbCivil;
		public System.Windows.Forms.RadioButton rbOficial;
	}
}