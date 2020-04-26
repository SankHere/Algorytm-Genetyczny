using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAPro
{
    public class Lab3
    {
        public int dHelp;

        public List<double> searchGx(List<double> fx, double d) {

            List<double> gx = new List<double>();

            double min = fx.Min();

            foreach(var item in fx)
            {
                gx.Add((item - min + d));
            }

            return gx;
        }

        public List<double> countPx(List<double> gx) {

            List<double> px = new List<double>();
            
            double suma = 0;
            foreach(var item in gx)
            {
                suma = suma + item;
            }

            foreach (var item in gx)
            {
                px.Add((item / suma));
            }


            return px;
        }

        public List<double> countQx(List<double> px)
        {
            List<double> qx = new List<double>();

            double limit = 0; 
            foreach(var item in px)
            {
                limit = limit + item;
                qx.Add(limit);
            }

            return qx;
        }

        public List<double> pickXreal(List<double> xreal, List<double> qx, List<double> r, double n)
        {
            List<double> xreal2 = new List<double>();

            int pickNumber = 0;
            foreach(var randomNumber in r)
            {
                pickNumber = 0;
                foreach(var limit in qx)
                {
                    if(randomNumber < limit)
                    {
                        break;
                    }
                    pickNumber++;
                }
                //zabezpieczenie mała szans ale moze wyjsc poza zakres, wina zaokragleń
                if (pickNumber > n)
                {
                    pickNumber = (int)n-1;
                }

                xreal2.Add(xreal[pickNumber]);
            }
            return xreal2;
        }

       public Lab3() { }
        public Lab3(int dHelp)
        {
            this.dHelp = dHelp;
        }
    }
}
