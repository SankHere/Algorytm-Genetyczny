using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAPro
{
    public class SwarmMolecule
    {
        Random rand = new Random();

        //generowanie początkowej wartości v czasteczki
        public double initVmolecule(double a, double b)
        {
            double r = rand.Next((int)-Math.Abs(a-b), (int)Math.Abs(a-b)+1);

            return r;
        }

        public List<double> initBgmolecule(double xreal, List<double> xrealList, List<double> fx, double rs)
        {
            int quantity = xrealList.Count();
            double quantityPercent = quantity - (quantity * (rs / 100));
            int quantityNeighbor =(int)(quantity - quantityPercent)-1;

            List<double> difference = new List<double>();
            List<double> differenceCopy = new List<double>();
            List<double> xrealBgList = new List<double>();

            foreach (var item in xrealList)
            {
                difference.Add(Math.Abs(xreal - item));
            }

            differenceCopy = difference.OrderBy(w => w). ToList();


            double howMuchDiff = differenceCopy[quantityNeighbor];
            xrealBgList.Clear();
            foreach (var item in xrealList)
            {
                if (Math.Abs(xreal - item) <= howMuchDiff)
                {
                    xrealBgList.Add(item);
                }
            }

           return xrealBgList;
        }
    }
}
