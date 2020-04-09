using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAPro
{
    public class GenerateTable
    {
        public int Lp { get; set; }
        public double xreal { get; set; }
        public double fx { get; set; }
        public double amount { get; set; }

        public GenerateTable(int Lp, double xreal, double fx, double amount)
        {
            this.Lp = Lp;
            this.xreal = xreal;
            this.fx = fx;
            this.amount = amount;
        }
      

    }
}
