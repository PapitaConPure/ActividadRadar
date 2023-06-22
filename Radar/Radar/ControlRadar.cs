namespace Radar {
	class ControlRadar {
		private Vehiculo[] infracciones = new Vehiculo[100];
		private bool ordenado = true;

		public int CantidadVehiculo { get; private set; }

		public Vehiculo AgregarControl(string patente, double velocidad, bool esOficial) {
			Vehiculo nuevo = new Vehiculo(patente, velocidad, esOficial);

			if(nuevo.VerificarVelocidadInfractor()) {
				this.infracciones[this.CantidadVehiculo] = nuevo;
				this.CantidadVehiculo++;
				this.ordenado = false;

				return nuevo;
			}
			
			return null;
		}

		public Vehiculo VerVehiculosInfractores(int idx) {
			if(idx < 0 || idx > this.CantidadVehiculo)
				return null;

			return infracciones[idx];
		}

		public Vehiculo BuscarPorPatenteBS(string patente) {
			if(!this.ordenado)
				this.Ordenar();

			int izq = 0;
			int der = this.CantidadVehiculo - 1;
			int centro;
			Vehiculo vehiculo = null;

			while(izq <= der && vehiculo == null) {
				centro = (izq + der) / 2;
				if(this.infracciones[centro].Patente == patente)
					vehiculo = this.infracciones[centro];
				else if(this.infracciones[centro].Patente.CompareTo(patente) < 0)
					izq = centro + 1;
				else if(this.infracciones[centro].Patente.CompareTo(patente) > 0)
					der = centro - 1;
			}

			return vehiculo;
		}

		public Vehiculo BuscarPorPatenteSQ(string patente) {
			int l = this.CantidadVehiculo;
			Vehiculo v = null;
			int i = 0;

			while(i < l && v == null) {
				if(this.infracciones[i].Patente == patente)
					v = this.infracciones[i];
				i++;
			}

			return v;
		}

		public void Ordenar() {
			int i, j, l = this.CantidadVehiculo;
			Vehiculo[] v = this.infracciones; //Referencia
			Vehiculo aux;

			for(i = 0; i < l - 1; i++) {
				for(j = i + 1; j < l; j++) {
					if(v[i].Patente.CompareTo(v[j].Patente) > 0) {
						#region Intercambiar
						aux = v[i];
						v[i] = v[j];
						v[j] = aux;
						#endregion
					}
				}
			}

			ordenado = true;
		}
	}
}
