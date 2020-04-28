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
            List<int> rangs = new List<int>();
            List<double> sortedFX = new List<double>();
            sortedFX = fx.OrderByDescending(s => s).ToList();

            int rang;

            foreach(var item in fx)
            {
                rang = 1;
                foreach(var item2 in sortedFX)
                {
                    if(item == item2)//może być problem jak będą dwa takie same w liście to  przyzna tą samą rangę
                    {
                        rangs.Add(rang);
                        break;
                    }else
                    {
                        rang++;
                    }
                }
                
            }
            return rangs;
        }
        public double px(int r, double tau)
        {
            double px;

            px = 1 / (Math.Pow(r, tau));

            return px;
        }

        public char doMutationGEO(char bit, double random, double px)
        {
            if(random < px)
            {
                if(bit.Equals('1'))
                {
                    return '0';
                }
                else
                {
                    return '1'; ;
                }
               
            }
            else{
                return bit;
            }
        }
    }
}
