using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAPro
{
    public class Molecule
    {
        public double X { get; set; }

        public double V { get; set; }

        public double Fx { get; set; }
        public double B { get; set; }
        public double Bg { get; set; }

        public Molecule(double X, double V, double Fx, double B, double Bg)
        {
            this.X = X;
            this.V = V;
            this.Fx = Fx;
            this.B = B;
            this.Bg = Bg;
        }
    }
}
