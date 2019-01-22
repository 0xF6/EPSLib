namespace EPS
{
    public class Particle
    {
        /// <summary>
        /// Mass
        /// </summary>
        public double M { get; protected set; }
        /// <summary>
        /// Energy
        /// </summary>
        public double E { get; protected set; }
        /// <summary>
        /// Electric charge
        /// </summary>
        public double Q { get; protected set; }
        /// <summary>
        /// Magnetic moment
        /// </summary>
        public double m { get; protected set; }
        /// <summary>
        /// Baryon charge
        /// </summary>
        public double B { get; protected set; }
        /// <summary>
        /// Lepton charge
        /// </summary>
        public double L { get; protected set; }
        /// <summary>
        /// Strangeness
        /// </summary>
        public long S { get; protected set; }
        /// <summary>
        /// Isotopic spin
        /// </summary>
        public QuantumState Iz { get; protected set; }
        /// <summary>
        /// G-parity
        /// </summary>
        public double ηG { get; protected set; }
        /// <summary>
        /// Super parity
        /// </summary>
        public double ηR { get; protected set; }
        /// <summary>
        /// Spin
        /// </summary>
        public QuantumState Sp { get; protected set; }



        /// <summary>
        /// Stable particle?
        /// </summary>
        public bool IsStable { get; protected set; }
    }
}
