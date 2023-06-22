namespace Radar {
	class ControlRadar {
		private Vehiculo[] infracciones;

		public int CantidadVehiculo { get; private set; }

		public void AgregarControl(string patente, double velocidad) {
			Vehiculo[] aux = new Vehiculo[infracciones.Length];
			infracciones.CopyTo(aux, 0);
			aux[infracciones.Length] = new Vehiculo(patente, velocidad, false);
			infracciones = aux;
		}

		public Vehiculo VerVehiculosInfractores(int idx) {
			return infracciones[idx];
		}

		public Vehiculo BuscarPorPatente(string patente) {
			foreach(Vehiculo infraccion in infracciones)
				if(infraccion.Patente == patente)
					return infraccion;

			return null;
		}
	}
}
