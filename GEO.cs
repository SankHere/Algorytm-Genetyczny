using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAPro
{
    public class GEO
    {

        public string changeBit(string xbin, int placeChange)
        {
                     
            if (xbin[placeChange] == '1')
            {
                xbin = xbin.Remove(placeChange, 1);
                xbin = xbin.Insert(placeChange, "0");
            }
            else
            {
                xbin = xbin.Remove(placeChange, 1);
                xbin = xbin.Insert(placeChange, "1");
            }

            return xbin;
        }

        //wyznaczanie rang
        public List<int> doRang(List<double> fx)
        {
            double px;


            return null;
        }
        public double px(int r, double tao)
        {
            double px;

            px = 1 / (Math.Pow(r, tao));

            return px;
        }
    }
}
