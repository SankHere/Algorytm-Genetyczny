using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAPro
{
    public class ConvertFromAndToDecimal
    {

        private static int MAX_BASE = 36;
        private static String pattern = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// Convert number to given base
        /// </summary>
        /// <param name="n">number to convert</param>
        /// <param name="newBase">base of result</param>
        /// <returns>returns converted n or null if an error occurs</returns>
        public String convertTo(int n, int newBase, double l)
        {
            String result = "";
            String help = "";

            //base is too big or too small
            if ((newBase > MAX_BASE) || (newBase < 2))
                return null;

            //n is equal to 0, do not process, return "0"
            if (n == 0)
                return "0";

            //process until n > 0
            while (n > 0)
            {
                result = pattern[n % newBase] + result;
                n /= newBase;
            }

         
            if(result.Length < l)
            {
                for(int z = result.Length; z < l; z++)
                {
                    help = help + "0";
                }
            }

            result = help + result;
            return result;
        }

        /// <summary>
        /// Returns value of character in a given base
        /// </summary>
        /// <param name="x">character to check</param>
        /// <param name="baseOfX">base of x</param>
        /// <returns>return value of x or -1 if an error occurs</returns>
        private static int valueOf(char x, int baseOfX)
        {
            for (int i = 0; i < baseOfX; i++)
            {
                if (x == pattern[i])
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Convert n to decimal
        /// </summary>
        /// <param name="n">number to convert</param>
        /// <param name="baseOfN">base of a given n</param>
        /// <returns>returns converted n or 0 if an error occurs</returns>
        public int convertFrom(String n, int baseOfN)
        {
            int i, x;
            int p = 1;
            int result = 0;

            //base is too big or too small
            if ((baseOfN > MAX_BASE) || (baseOfN < 2))
                return 0;

            n = n.ToUpper();

            for (i = n.Length - 1; i >= 0; i--)
            {
                x = valueOf(n[i], baseOfN);
                if (x < 0)
                {
                    return 0;
                }
                result += (x * p);
                p *= baseOfN;
            }

            return result;
        }

    }
}
