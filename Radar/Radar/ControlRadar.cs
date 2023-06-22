namespace Radar {
	class ControlRadar {
		private Vehiculo[] infracciones = new Vehiculo[100];

		public int CantidadVehiculo { get; private set; }

		public Vehiculo AgregarControl(string patente, double velocidad, bool esOficial) {
			Vehiculo nuevo = new Vehiculo(patente, velocidad, esOficial);
			this.infracciones[this.CantidadVehiculo] = nuevo;
			this.CantidadVehiculo++;
			return nuevo;
		}

		public Vehiculo VerVehiculosInfractores(int idx) {
			if(idx < 0 || idx > this.CantidadVehiculo)
				return null;

			return infracciones[idx];
		}

		public Vehiculo BuscarPorPatente(string patente) {
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
	}
}
