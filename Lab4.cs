using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ISAPro
{
    public class Lab4
    {

        public List<string> serachParets(List<string> xreal2bin, List<double> random, double Pk)
        {
            List<string> xParents = new List<string>();
            int pom = 0;
            foreach(var item in random)
            {
                if(item <= Pk)
                {
                    xParents.Add(xreal2bin[pom]);
                }
                else
                {
                    xParents.Add(null);
                }
                pom++;
            }
            return xParents;
        }

        public List<int> searchSection(List<string> xParents, double l)
        {
            List<int> Pc = new List<int>();

            Random rnd = new Random();
            int help = 0;

            int section = rnd.Next(1, (int)l - 1);

            foreach (var item in xParents)
            {
                if(help >= 2)
                {
                    section = rnd.Next(1, (int)l - 1);
                    help = 0;
                }
                if(item != null)
                {
                    Pc.Add(section);
                    help++;
                }
                else
                {
                    Pc.Add(0);
                }
            }
            return Pc;
        }


        public List<string> doChildren(List<string> xParents, List<int> Pc, double n)
        {
            List<string> children = new List<string>();

            string firstParent = "";
            string secondParent = "";

            string firstChild = "";
            string secondChild = "";

            string r11 = "";
            string r12 = "";
            string r21 = "";
            string r22 = "";

            int length = 0;
            int help = 0;
            int help2 = 0;
            int help3 = 0;

            int even = 0;
            string notNull = null;

            foreach (var item in xParents)
            {
                if (item == null)
                {
                    even++;
                }
            }

           foreach (var item in xParents)
            {
                if (item != null)
                {
                    notNull = item;

                    if (even % 2 != 0 && xParents.Count == help+1)
                    {
                        children.Add(notNull);
                        break;
                    }

                    
                    firstParent = secondParent;
                    secondParent = item;

                    if (help2 >= 1)
                    {
                        length = firstParent.Length - Pc[help];
                        int h = Pc.Count;
                        r11 = firstParent.Substring(0, Pc[help]);
                        r12 = firstParent.Substring(Pc[help], length);

                        r21 = secondParent.Substring(0, Pc[help]);
                        r22 = secondParent.Substring(Pc[help], length);

                        firstChild = r11 + r22;
                        //secondChild = r12 + r21;
                        secondChild = r21 + r12;
                        children.Add(firstChild);
                        if(help3 > 0)
                        {
                            for(int i=0; i < help3; i++)
                            {
                                children.Add(null);
                            }
                            
                            help3 = 0;
                        }
                        children.Add(secondChild);

                        help2 = 0;
                        
                    }
                    else
                    {
                        help2++;
                    }                    
                }
                else
                {
                    if (even % 2 != 0 && xParents.Count == help + 1)
                    {
                        children.Add(notNull);
                        if(children.Count != xParents.Count)
                        {
                            for(int i=children.Count; i<xParents.Count; i++)
                            {
                                children.Add(null);
                            }
                        }
                        break;
                    }
                    if(help2 < 1)
                    {
                        children.Add(null);
                    }
                    else
                    {
                        help3++;
                    }                  
                }
                help++;
            }
            if (children.Count < n)
            {
                for (int doMore = children.Count; doMore < n; doMore++)
                {
                    children.Add(null);
                }
            }
            return children;
        }

        public List<string> doXbinChildren(List<string> children, List<string> xreal2bin)
        {

            List<string> xbinChildren = new List<string>();
            int helps = 0;

            foreach (var item in children)
            {
                
                if (item != null)
                {
                    xbinChildren.Add(item);
                }else
                {
                    xbinChildren.Add(xreal2bin[helps]);
                }
                
                helps++;
                
            }

            return xbinChildren;
        }

        public List<int> searchMutation(List<double> randomNumbers, double Pm)
        {
            List<int> pointsMutation = new List<int>();

            int k = 0;
            foreach (var number in randomNumbers)
            {
                if(number < Pm)
                {                     
                    pointsMutation.Add(k+1);
                }
                else
                {
                    pointsMutation.Add(0);
                }
                k++;
            }
            return pointsMutation;
        }

        public string doMutation(string xbinChildren, List<int> searchMutation)
        {
            string xbinMutation = xbinChildren;
           
            foreach(var item in searchMutation)
            {
                if(item != 0)
                {
                    if(xbinChildren[item-1] == '1')
                    {
                        xbinMutation = xbinMutation.Remove(item-1, 1);
                        xbinMutation = xbinMutation.Insert(item - 1, "0");
                    }
                    else
                    {
                        xbinMutation = xbinMutation.Remove(item - 1, 1);
                        xbinMutation = xbinMutation.Insert(item - 1, "1");
                    }
                }
            }

            return xbinMutation;
        }
    }
}
