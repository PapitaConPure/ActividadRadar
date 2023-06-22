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
			this.AgregarValoresDePrueba();
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

				if(vehiculo == null)
					this.lsbInfracciones.Items.Add("Patente no encontrada");
				else {
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
				textoOficial = "OFI";
			else
				textoOficial = "NOF";

			return $"{vehiculo.Patente} ({textoOficial}) // {vehiculo.Velocidad}km/h";
		}

		private void AgregarValoresDePrueba() {
			control.AgregarControl("EFX-019", 159.5, false);
			control.AgregarControl("ABC-879", 24.30, false);
			control.AgregarControl("HJK-312", 49.93, true );
			control.AgregarControl("ALI-132", 30.00, false);
			control.AgregarControl("POZ-558", 180.7, true );
			control.AgregarControl("JCO-614", 44.50, false);
			control.AgregarControl("ZTU-428", 93.78, false);
		}
	}
}
