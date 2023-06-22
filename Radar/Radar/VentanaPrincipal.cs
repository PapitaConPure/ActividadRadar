using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radar {
    public partial class VentanaPrincipal: Form {
		ControlRadar control = new ControlRadar();

        public VentanaPrincipal() {
			this.InitializeComponent();
        }

		private void btnAgregar_Click(object sender, EventArgs e) {
			VentanaInfraccion f = new VentanaInfraccion();
			DialogResult resultado = f.ShowDialog();
			if(resultado != DialogResult.OK)
				return;

			control.AgregarControl(f.tbPatente.Text, (double)f.nudVelocidad.Value, f.rbOficial.Checked);
		}

		private void btnBuscar_Click(object sender, EventArgs e) {
			if(this.tbPatente.Text.Length > 0) {
				this.lsbInfracciones.Items.Clear();
				Vehiculo vehiculo = control.BuscarPorPatenteBS(this.tbPatente.Text);

				if(vehiculo != null) {
					string linea = this.DarFormatoEnLista(vehiculo);
					this.lsbInfracciones.Items.Add(linea);
				}
			}

			this.tbPatente.Clear();
		}

		private void btnListar_Click(object sender, EventArgs e) {
			this.ListarTodos();
		}

		private void ListarTodos() {
			this.lsbInfracciones.Items.Clear();
			for(int i = 0; i < control.CantidadVehiculo; i++) {
				Vehiculo v = control.VerVehiculosInfractores(i);
				string linea = this.DarFormatoEnLista(v);
				this.lsbInfracciones.Items.Add(linea);
			}
		}

		private string DarFormatoEnLista(Vehiculo vehiculo) {
			string textoOficial;

			if(vehiculo.EsOficial)
				textoOficial = "Oficial";
			else
				textoOficial = "No Oficial";

			return $"{vehiculo.Patente} ({textoOficial}) // {vehiculo.Velocidad}km/h";
		}
	}
}
