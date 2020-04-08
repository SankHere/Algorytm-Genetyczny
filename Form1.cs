using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace ISAPro
{
    public partial class Form1 : Form
    {
        //tworzenie obiektu klasy do wyświetlania
        List<GenerateTable> genTable;
        Random random = new Random();
        public Form1()
        {

            InitializeComponent();

            genTable = new List<GenerateTable>();
            generateTableBindingSource.DataSource = genTable;
            dataGridView1.DataSource = generateTableBindingSource;

            ((CurrencyManager)BindingContext[genTable]).Refresh();

        }
        //lab5
        private void Lab5_Click(object sender, EventArgs e)
        {
            GenerateTxt1();
            dataGridView1.Rows.Clear();
            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            double d = Convert.ToDouble(textBoxD.Text);
            string dHelp = textBoxD.Text.Split(',').Last();

            double n = Convert.ToDouble(textBoxN.Text);
            double l = Math.Ceiling(Math.Log(((1 / d) * (b - a) + 1), 2)); // obliczanie l czyli na ilu bitach się liczba zmiejsci

            double Pk = Convert.ToDouble(textBoxPk.Text);
            double Pm = Convert.ToDouble(textBoxPm.Text);
            int T = Convert.ToInt32(textBoxT.Text);

            List<double> xreal = new List<double>();
            List<double> fx = new List<double>();
            List<double> gx = new List<double>();
            List<double> px = new List<double>();
            List<double> qx = new List<double>();
            List<double> r = new List<double>();
            List<double> xreal2 = new List<double>();


            List<int> xreal2int = new List<int>();
            List<string> xreal2bin = new List<string>();
            List<string> xParents = new List<string>();
            List<int> Pc = new List<int>();
            List<string> children = new List<string>();
            List<string> xbinChildren = new List<string>();

            List<List<int>> pointsMutation = new List<List<int>>();
            List<string> xbinMutation = new List<string>();

            List<int> xreal3int = new List<int>();
            List<double> xreal3 = new List<double>();

            List<double> fxmax = new List<double>();
            List<double> fxavg = new List<double>();
            List<double> fxmin = new List<double>();

            double elitefx = 0;
            double elitexreal = 0;
            List<double> elitefxlist = new List<double>();
            List<double> elitexreallist = new List<double>();

            Dictionary<double, int> dict = new Dictionary<double, int>(); //do obliczania wystapien danego elementu
            
            //do wyników ostatecznych
            List<double> resultXreal = new List<double>();
            List<double> resultFx = new List<double>();
            List<int> resultOccurrence = new List<int>();
            
            int j = 0;
            //int el = 0;

            Lab3 lab3 = new Lab3(dHelp.Length);

            ConvertFromAndToDecimal convertFromAndToDecimal = new ConvertFromAndToDecimal();

            Lab4 lab4 = new Lab4();

            xreal = InitPopulation(a, b, n); //wygenerowanie populacji xReal
                     
            for (int z = 0; z < T; z++)
            {
                fx = CalculateFunction(xreal); // wyliczenie funkcji f(x)
                /*
                //wyznaczanie elity
                el = 0;
                elitefx = fx.Max();
                foreach(var elite in fx)
                {                 
                    if (fx.Max() == elite)
                    {                 
                        elitexreal = xreal[el];
                        break;
                    }
                    el++;
                }*/

                gx = lab3.searchGx(fx, d);
                px = lab3.countPx(gx);
                qx = lab3.countDx(px);
                r = RandomNumber(n);
                xreal2 = lab3.pickXreal(xreal, qx, r, n); // populacja po selekcji 

                //4laby 

                xreal2int = FromXrealToXint(xreal2, a, b, l); //wygenerowanie xreal2int (xreal2 -> xint)
                xreal2bin.Clear();
                foreach (var item in xreal2int)    // wygenerowanie ciagu binarnego (xreal2int -> xreal2bin)
                {
                    xreal2bin.Add(convertFromAndToDecimal.convertTo(item, 2, l));
                }

                r = RandomNumber(n);

                xParents = lab4.serachParets(xreal2bin, r, Pk);  //generowania pokolenia rodziców 

                Pc = lab4.searchSection(xParents, l);

                children = lab4.doChildren(xParents, Pc);
                xbinChildren = lab4.doXbinChildren(children, xreal2bin);

                pointsMutation.Clear();
                foreach (var item in xbinChildren)
                {
                    r = RandomNumber(l);
                    pointsMutation.Add(lab4.searchMutation(r, Pm));
                }

                j = 0;
                xbinMutation.Clear();
                foreach (var item in xbinChildren)
                {
                    xbinMutation.Add(lab4.doMutation(item, pointsMutation[j]));
                    j++;
                }
                xreal3int.Clear();
                foreach (var item in xbinMutation)    // wygenerowanie xint (xbin -> xint)
                {
                    xreal3int.Add(convertFromAndToDecimal.convertFrom(item, 2));
                }

                xreal3 = FromXintToXreal(xreal3int, a, b, l); //wygenerowanie z xint1 do xreal1

                fx = CalculateFunction(xreal3); // wyliczenie funkcji f(x)

                /*dodawanie elity do wyników
                el = 0;
                foreach (var elite in fx)
                {
                    if(elitefx > elite)
                    {
                        fx[el] = elitefx;
                        xreal3[el] = elitexreal;
                        break;
                    }
                    el++;
                }*/

                elitefxlist.Add(elitefx);
                elitexreallist.Add(elitexreal);

                xreal = xreal3;
            }

            dict = countOccurrence(xreal3);
            
            foreach(var item in dict)
            {
                resultXreal.Add(item.Key);
        

                resultOccurrence.Add((int)(((double)item.Value / (double)xreal.Count()) * 100));
            }

            resultFx = CalculateFunction(resultXreal);

            for (int i = 0; i < resultXreal.Count; i++)
            {
                genTable.Add(new GenerateTable(i + 1, resultXreal[i], resultFx[i], resultOccurrence[i]));
            }

            dataGridView1.DataSource = genTable;
            dataGridView1.DataSource = generateTableBindingSource;

            ((CurrencyManager)BindingContext[genTable]).Refresh();
        }


       /* public void GenerateTxt(double a, double b, double n, double Pk, double Pm, int T, List<double> xreal, List<double> fx)
        {
            string fileName = "Spis pokolen.txt";
            string pathString = System.IO.Path.Combine("", fileName);
        }*/
        public void GenerateTxt1()
        {
            string fileName = "Spis pokolen.txt";
            string test = Path.GetTempPath();

            string pathString = Path.Combine("", fileName);

            if (!File.Exists(pathString))
            {
                //File.Create(pathString);
                File.WriteAllText(pathString, "Inny tekst");

                File.WriteAllText(pathString, "Drugi tesk");
            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", fileName);
                return;
            }

        }

        public Dictionary<double, int> countOccurrence(List<double> xreal)
        {
            var dict = new Dictionary<double, int>();

            int wqeqwe = xreal.Count;
            foreach (var i in xreal)
            {
                if (dict.ContainsKey(i))
                    dict[i]++;
                else
                    dict[i] = 1;
            }
            return dict;
        }


        public List<double> InitPopulation(double a, double b, double n)
        {

            List<double> randomList = new List<double>(); // lista do wylosowanych liczb
            List<double> listOfPopulation = new List<double>(); //lista populacji

            randomList = RandomNumber(n);

            string dHelp = textBoxD.Text.Split(',').Last();

            foreach (var item in randomList)
            {
                Console.WriteLine((item * (b - a) + a));
                listOfPopulation.Add(Math.Round((item * (b - a) + a), dHelp.Length));//zaokroąglanie 
            }

            return listOfPopulation;
        }

        //funkcja losujaca liczby od 0-n
        public List<double> RandomNumber(double n)
        {
           
            List<double> randomList = new List<double>();

            double r = 0;
            //losujemy liczby z zakresu 0-1
            for (int i = 0; i < n; i++)
            {
                r = random.NextDouble();

                randomList.Add(r);

            }
            return randomList;
        }

        //obliczanie fx
        public List<double> CalculateFunction(List<double> xreal1)
        {
            List<double> fx = new List<double>();
            double function = 0;
            foreach (var x in xreal1)
            {
                function = (x - (int)x) * (Math.Cos(20 * Math.PI * x) - Math.Sin(x));
                fx.Add(function);
            }

            return fx;
        }

        public List<int> FromXrealToXint(List<double> xreal, double a, double b, double l)
        {

            List<int> xint = new List<int>();

            foreach (var item in xreal)
            {
                xint.Add((int)((1 / (b - a)) * (item - a) * (Math.Pow(2, l) - 1)));
            }

            return xint;
        }

        public List<double> FromXintToXreal(List<int> xint1, double a, double b, double l)
        {
            List<double> xreal1 = new List<double>();

            string dHelp = textBoxD.Text.Split(',').Last();

            foreach (var item in xint1)
            {
                xreal1.Add(Math.Round((((b - a) * item) / (Math.Pow(2, l) - 1) + a), dHelp.Length));
            }
            return xreal1;
        }
        /*
        //lab4
        private void lab4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            double d = Convert.ToDouble(textBoxD.Text);
            string dHelp = textBoxD.Text.Split(',').Last();

            double n = Convert.ToDouble(textBoxN.Text);
            double l = Math.Ceiling(Math.Log(((1 / d) * (b - a) + 1), 2)); // obliczanie l czyli na ilu bitach się liczba zmiejsci

            double Pk = Convert.ToDouble(textBoxPk.Text);
            double Pm = Convert.ToDouble(textBoxPm.Text);

            List<double> xreal = new List<double>();
            List<double> fx = new List<double>();
            List<double> gx = new List<double>();
            List<double> px = new List<double>();
            List<double> qx = new List<double>();
            List<double> r = new List<double>();
            List<double> xreal2 = new List<double>();


            List<int> xreal2int = new List<int>();
            List<string> xreal2bin = new List<string>();
            List<string> xParents = new List<string>();
            List<int> Pc = new List<int>();
            List<string> children = new List<string>();
            List<string> xbinChildren = new List<string>();
  
            List<List<int>> pointsMutation = new List<List<int>>();
            List<string> pointsMut = new List<string>();
            List<string> xbinMutation = new List<string>();

            List<int> xreal3int = new List<int>();
            List<double> xreal3 = new List<double>();
            int time = 0;
            int j = 0;
            xreal = InitPopulation(a, b, n); //wygenerowanie populacji xReal
            fx = CalculateFunction(xreal); // wyliczenie funkcji f(x)

            Lab3 lab3 = new Lab3(dHelp.Length);

            gx = lab3.searchGx(fx, d);
            px = lab3.countPx(gx);
            qx = lab3.countDx(px);
            r = RandomNumber(n);
            xreal2 = lab3.pickXreal(xreal, qx, r, n); // populacja po selekcji 

            //4laby 
            ConvertFromAndToDecimal convertFromAndToDecimal = new ConvertFromAndToDecimal();

            xreal2int = FromXrealToXint(xreal2, a, b, l); //wygenerowanie xreal2int (xreal2 -> xint)
            foreach (var item in xreal2int)    // wygenerowanie ciagu binarnego (xreal2int -> xreal2bin)
            {
                xreal2bin.Add(convertFromAndToDecimal.convertTo(item, 2, l));
            }

            r = RandomNumber(n);

            Lab4 lab4 = new Lab4();

            xParents = lab4.serachParets(xreal2bin, r, Pk);  //generowania pokolenia rodziców 

            Pc = lab4.searchSection(xParents, l);

            children = lab4.doChildren(xParents, Pc);
            xbinChildren = lab4.doXbinChildren(children, xreal2bin);

            Random rand = new Random();
            foreach(var item in xbinChildren)
            {
                r = RandomNumber(l);
                time = rand.Next(1, 10);
                Thread.Sleep(time);
                pointsMutation.Add(lab4.searchMutation(r, Pm, l));
            }
            string helpString = " ";
            foreach (var item in pointsMutation)
            {
                helpString = " ";
                foreach (var item1 in item)
                {
                    if(item1 != 0)
                    {
                        helpString = helpString + " " + item1;
                    }
                   
                }
                pointsMut.Add(helpString);
            }

            j = 0;

            foreach(var item in xbinChildren)
            {
                xbinMutation.Add(lab4.doMutation(item, pointsMutation[j]));
                j++;
            }

            foreach (var item in xbinMutation)    // wygenerowanie xint (xbin -> xint)
            {
                xreal3int.Add(convertFromAndToDecimal.convertFrom(item, 2));
            }

            xreal3 = FromXintToXreal(xreal3int, a, b, l); //wygenerowanie z xint1 do xreal1


            fx = CalculateFunction(xreal3); // wyliczenie funkcji f(x)

           
            for (int i = 0; i < n; i++)
            {

                genTable.Add(new GenerateTable(i + 1, xreal2[i], xreal2bin[i], xParents[i], Pc[i], children[i], xbinChildren[i], pointsMut[i], xbinMutation[i], xreal3[i], fx[i]));
                
            }

            dataGridView1.DataSource = genTable;
            dataGridView1.DataSource = generateTableBindingSource;

            ((CurrencyManager)BindingContext[genTable]).Refresh();
        }
        */
        /* lab3
        private void lab3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            double d = Convert.ToDouble(textBoxD.Text);
            string dHelp = textBoxD.Text.Split(',').Last();

            double n = Convert.ToDouble(textBoxN.Text);
            double l = Math.Ceiling(Math.Log(((1 / d) * (b - a) + 1), 2)); // obliczanie l czyli na ilu bitach się liczba zmiejsci

            List<double> xreal = new List<double>();
            List<double> fx = new List<double>();
            List<double> gx = new List<double>();
            List<double> px = new List<double>();
            List<double> qx = new List<double>();
            List<double> r = new List<double>();
            List<double> xreal2 = new List<double>();

            xreal = InitPopulation(a, b, n); //wygenerowanie populacji xReal
            fx = CalculateFunction(xreal); // wyliczenie funkcji f(x)

            Lab3 lab3 = new Lab3(dHelp.Length);

            gx = lab3.searchGx(fx, d);
            px = lab3.countPx(gx);
            qx = lab3.countDx(px);
            r = RandomNumber(n);
            xreal2 = lab3.pickXreal(xreal, qx, r, n);


            
            for (int i = 0; i < n; i++)
            {
                genTable.Add(new GenerateTable(i + 1, xreal[i], fx[i], gx[i], Convert.ToDecimal(px[i]), qx[i], r[i], xreal2[i]));

            }

            dataGridView1.DataSource = genTable;
            dataGridView1.DataSource = generateTableBindingSource;

            ((CurrencyManager)BindingContext[genTable]).Refresh();
        }*/
        /*
        lab2 
        private void StartButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            double d = Convert.ToDouble(textBoxD.Text);
            
            double n = Convert.ToDouble(textBoxN.Text);
            double l = Math.Ceiling(Math.Log(((1 / d) * (b - a) + 1), 2)); // obliczanie l czyli na ilu bitach się liczba zmiejsci

            List<double> xreal = new List<double>();
            List<double> fx = new List<double>();

            List<int> xint = new List<int>();
            List<string> xbin = new List<string>();
            List<int> xint1 = new List<int>();
            List<double> xreal1 = new List<double>();         

            ConvertFromAndToDecimal convertFormAndToDecimal = new ConvertFromAndToDecimal();

            xreal = InitPopulation(a, b, n); //wygenerowanie populacji xReal
            xint = FromXrealToXint(xreal, a, b, l); //wygenerowanie xint (xreal -> xint)

            foreach(var item in xint)    // wygenerowanie ciagu binarnego (xint -> xbin)
            {
                xbin.Add(convertFormAndToDecimal.convertTo(item, 2, l));
            }

            foreach (var item in xbin)    // wygenerowanie xint (xbin -> xint)
            {
                xint1.Add(convertFormAndToDecimal.convertFrom(item, 2));
            }

            xreal1 = FromXintToXreal(xint1, a, b, l); //wygenerowanie z xint1 do xreal1
            

           
            fx = CalculateFunction(xreal); // wyliczenie funkcji f(x)

            

            for(int i = 0; i<n; i++)
            {
                genTable.Add(new GenerateTable(i + 1, xreal[i], xint[i], xbin[i], xint1[i], xreal1[i], fx[i]));

            }

            dataGridView1.DataSource = genTable;
            dataGridView1.DataSource = generateTableBindingSource;

            ((CurrencyManager)BindingContext[genTable]).Refresh();

            //genTable.Clear();

        }
        */

    }
}
