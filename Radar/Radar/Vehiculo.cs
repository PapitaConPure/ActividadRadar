namespace Radar {
	class Vehiculo {
		public Vehiculo(string patente, double velocidad, bool esOficial) {
			this.Patente = patente;
			this.Velocidad = velocidad;
			this.EsOficial = esOficial;
		}

		public string Patente { get; private set; }

		public double Velocidad { get; private set; }

		public bool EsOficial { get; private set; }

		public bool VerificarVelocidadInfractor() {
			return this.Velocidad < 50 || this.Velocidad > 90;
		}
	}
}
