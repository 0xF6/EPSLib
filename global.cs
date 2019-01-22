namespace System.Internal
{
    using EPS;
    using EPS.Particles;

    /// <summary>
    /// Global constats
    /// </summary>
    public class global
    {
        public static readonly double d = 1E-27;
        public static readonly double h = 1.054572E-0 * d;
        public static readonly double c = 299_792_458;
        public static readonly double ln2 = 0.693E-0; 
        public static readonly double g = 0.00000000006673; // Big G


        public static void Sim()
        {
            new Photon();
            new Electron();
        }
    }
}