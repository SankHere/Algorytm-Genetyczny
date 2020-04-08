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
        public int amount { get; set; }

        public GenerateTable(int Lp, double xreal, double fx, int amount)
        {
            this.Lp = Lp;
            this.xreal = xreal;
            this.fx = fx;
            this.amount = amount;
        }
        /*
        //Lab4
        public int Lp { get; set; }
        public double xreal { get; set; }
        public string xbin { get; set; }
        public string parent { get; set; }
        public int Pc { get; set; }
        public string children { get; set; }
        public string generationAfterCrossing { get; set; }
        public string Pm { get; set; }
        public string generationAfterMutation { get; set; }
        public double xreal2 { get; set; }
        public double fx { get; set; }
        
        public GenerateTable(int Lp, double xreal, string xbin, string parent, int Pc, string children, string generationAfterCrossing, string Pm, string generationAfterMutation, double xreal2, double fx)
        {
            this.Lp = Lp;
            this.xreal = xreal;
            this.xbin = xbin;
            this.parent = parent;
            this.Pc = Pc;
            this.children = children;
            this.generationAfterCrossing = generationAfterCrossing;
            this.Pm = Pm;
            this.generationAfterMutation = generationAfterMutation;
            this.xreal2 = xreal2;
            this.fx = fx;
        }
        */

        /*
        //Lab3 
        public double xreal { get; set; }

        //lab3
        public double gx { get; set; }
        public decimal px { get; set; }
        public double qx { get; set; }
        public double r { get; set; }
        public double xreal2 { get; set; }
         

        //lab2 
        public int xint { get; set; }

        public string xbin { get; set; }
        public int xint1 { get; set; }
        public double xreal1 { get; set; }
        public double fx { get; set; }

        public GenerateTable() { }

        public GenerateTable(int Lp, double xreal, double fx, double gx, decimal px, double qx, double r, double xreal2)
        {
            this.Lp = Lp;
            this.xreal = xreal;
            this.fx = fx;
            this.gx = gx;
            this.px = px;
            this.qx = qx;
            this.r = r;
            this.xreal2 = xreal2;
        }

        public GenerateTable(int Lp, double xreal, int xint, string xbin, int xint1, double xreal1, double fx)
        {
            this.Lp = Lp;
            this.xreal = xreal;
            this.xint = xint;
            this.xbin = xbin;
            this.xint1 = xint1;
            this.xreal1 = xreal1;
            this.fx = fx;
        }
        */

    }
}
