namespace EPS.Particles
{
    using System;
    using System.Internal;

    public class Electron : Particle, Lepton
    {
        public Electron()
        {
            t = LifeTime.Infinity;
            E = -1.6021766208 * 1E-19;
            m = -9.274009994 * 1E-24;
            M = 5.48579909070 * 1E-4;
            L = 1E-0;
        }
    }
}