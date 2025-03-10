﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radar {
	public partial class VentanaInfraccion: Form {
		public VentanaInfraccion() {
			this.InitializeComponent();
		}

		private void tbPatente_TextChanged(object sender, EventArgs e) {
			this.ComprobarActivar();
		}

		private void nudVelocidad_ValueChanged(object sender, EventArgs e) {
			this.ComprobarActivar();
		}

		private void nudVelocidad_KeyUp(object sender, KeyEventArgs e) {
			this.ComprobarActivar();
		}

		private void ComprobarActivar() {
			if(this.tbPatente.Text.Length > 0
			&& this.nudVelocidad.Value > 0)
				this.btnAceptar.Enabled = true;
			else
				this.btnAceptar.Enabled = false;
		}
	}
}
