namespace EPS.Particles
{
    using System;

    public class Photon : Particle, Boson
    {
        public Photon()
        {
            Sp = new QuantumState(1);
            IsStable = true;
            t = LifeTime.Stable;
            M = 1E-27;
            E = 1E-35;
        }
    }

    
}
