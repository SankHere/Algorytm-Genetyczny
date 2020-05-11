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
using System.Diagnostics;

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


        private void ANW_Click(object sender, EventArgs e)
        {
            //zmienne od użytkownika
            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            double d = Convert.ToDouble(textBoxD.Text);
            string dHelp = textBoxD.Text.Split(',').Last();
            double l = Math.Ceiling(Math.Log(((1 / d) * (b - a) + 1), 2)); // obliczanie l czyli na ilu bitach się liczba zmiejsci
            int T = Convert.ToInt32(textBoxT.Text);

            List<double> xreal = new List<double>();
            List<double> xrealChange = new List<double>();
            double xrealc = 0;
            List<double> fx = new List<double>();
            List<double> fxc = new List<double>();
            List<double> fxlocal = new List<double>();

            double fxcc = 0;
            List<int> xint = new List<int>();
            //wyniki po zmianie bitu
            List<string> xbinChange = new List<string>();
            string xbin = "";
            string xbinc = "";

            //zmienne do zapisania najlepszych wyników
            double xrealbest = 0;
            double fxbest = 0;
            string xbinbest = "";

            //zmienne pętle
            int t = 0;
            int i = 0;
            double w = 0.0;
            int licznik = 0;
            double measure = 0.0;
            bool local = false;

            ConvertFromAndToDecimal convertFromAndToDecimal = new ConvertFromAndToDecimal();
            GEO geo = new GEO();

            //test tab
            int[] tabtest = new int[T];
            List<double> listsumm = new List<double>();
            int[] tabsumm = new int[T];

            chart3.Titles.Clear();
            chart3.Series["Efektywnosc"].Points.Clear();
            chart3.Titles.Add("Efektywnosc");


            for (int powtorz = 0; powtorz < 1000; powtorz++)                
            {
                
                for (t = 0; t < T; t++)
                {
                    xreal = InitPopulation(a, b, 1);
                    local = false;
                    licznik = 0;
                    while (!local)
                    {
                        fxc = CalculateFunction(xreal);
                        xint = FromXrealToXint(xreal, a, b, l);
                        xbin = convertFromAndToDecimal.intToBinarty(xint[0], l);

                        //zmiana bitów
                        xbinChange.Clear();
                        for (i = 0; i < xbin.Length; i++)
                        {
                            xbinChange.Add(geo.changeBit(xbin, i));
                        }

                        //zmina z xbin -> xint aby wyznaczyć wartości funkcji
                        xint.Clear();
                        foreach (var item in xbinChange)    // wygenerowanie xint (xbin -> xint)
                        {
                            xint.Add(convertFromAndToDecimal.convertFrom(item, 2));
                        }

                        xrealChange = FromXintToXreal(xint, a, b, l); //wygenerowanie z xint do xreal

                        //obliczanie funkji 
                        fx = CalculateFunction(xrealChange);

                        i = 0;
                        //obliczanie na którym elemencie jest najlepsze fx
                        foreach (var os in fx)
                        {
                            if (os == fx.Max())
                            {
                                break;
                            }
                            i++;
                        }

                        //sprawdzanie warunku stopu
                        if (fxc[0] < fx.Max())
                        {
                            xreal[0] = xrealChange[i];
                            fxc[0] = fx.Max();


                            xrealc = xrealChange[i];
                            fxcc = fx.Max();
                            xbinc = xbinChange[i];

                        }
                        else
                        {
                            local = true;
                        }

                    }


                    if (fxbest < fxcc)
                    {
                        xrealbest = xrealc;
                        fxbest = fxcc;
                        xbinbest = xbinc;
                    }

                    if (fxcc >= 1.9)
                    {
                        //znaleziono rozwiązanie w T == t
                        tabtest[t]++;
                        break;
                    }

                }

                //wypisywanie na okienko
                richTextBoxGEO.Text = "ANW Najlepszy wynik: \nxreal: " + xrealbest + " \nxbin: " + xbinbest + " \nfx: " + fxbest;
            }

            int sum = 0;
            double wynik = 0;
            foreach(var item in tabtest)
            {
                sum = sum + item;
                wynik = (double)sum / (double)T;
                listsumm.Add(wynik);
            }
            i = 0;
            foreach(var item in listsumm)
            {
                i++;
                chart3.Series["Efektywnosc"].Points.AddXY(i, item*10);
            }
            

        }
        


        private void ANW_Click(object sender, EventArgs e)
        {
            //zmienne od użytkownika
            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            double d = Convert.ToDouble(textBoxD.Text);
            string dHelp = textBoxD.Text.Split(',').Last();
            double l = Math.Ceiling(Math.Log(((1 / d) * (b - a) + 1), 2)); // obliczanie l czyli na ilu bitach się liczba zmiejsci
            int T = Convert.ToInt32(textBoxT.Text);

            List<double> xreal = new List<double>();
            List<double> xrealChange = new List<double>();
            double xrealc = 0;
            List<double> fx = new List<double>();
            List<double> fxc = new List<double>();
            List<double> fxlocal = new List<double>();

            double fxcc = 0;
            List<int> xint = new List<int>();
            //wyniki po zmianie bitu
            List<string> xbinChange = new List<string>();
            string xbin = "";
            string xbinc = "";

            //zmienne do zapisania najlepszych wyników
            double xrealbest = 0;
            double fxbest = 0;
            string xbinbest = "";

            //zmienne pętle
            int t = 0;
            int i = 0;
            double w = 0.0;
            int licznik = 0;
            double measure = 0.0;
            bool local = false;

            ConvertFromAndToDecimal convertFromAndToDecimal = new ConvertFromAndToDecimal();
            GEO geo = new GEO();

            chart3.Series.Clear();
            chart3.Titles.Clear();
            chart3.Series.Add("FxBest");
            chart3.Series["FxBest"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart3.Series["FxBest"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart3.Titles.Add("Historia");

            for (t=0; t<T; t++)
            {
                xreal = InitPopulation(a, b, 1);
                local = false;
                licznik = 0;
                while (!local)
                {
                    fxc = CalculateFunction(xreal);
                    xint = FromXrealToXint(xreal, a, b, l);
                    xbin = convertFromAndToDecimal.intToBinarty(xint[0], l);

                    //zmiana bitów
                    xbinChange.Clear();
                    for (i = 0; i < xbin.Length; i++)
                    {
                        xbinChange.Add(geo.changeBit(xbin, i));
                    }

                    //zmina z xbin -> xint aby wyznaczyć wartości funkcji
                    xint.Clear();
                    foreach (var item in xbinChange)    // wygenerowanie xint (xbin -> xint)
                    {
                        xint.Add(convertFromAndToDecimal.convertFrom(item, 2));
                    }

                    xrealChange = FromXintToXreal(xint, a, b, l); //wygenerowanie z xint do xreal

                    //obliczanie funkji 
                    fx = CalculateFunction(xrealChange);

                    i = 0;
                    //obliczanie na którym elemencie jest najlepsze fx
                    foreach(var os in fx)
                    {
                        if (os == fx.Max())
                        {
                            break;
                        }
                        i++;
                    }
                    
                    //sprawdzanie warunku stopu
                    if (fxc[0] < fx.Max())
                    {
                        xreal[0] = xrealChange[i];
                        fxc[0] = fx.Max();


                        xrealc = xrealChange[i];                      
                        fxcc = fx.Max();
                        xbinc = xbinChange[i];

                    }
                    else
                    {
                        local = true;
                    }
                    fxlocal.Add(fxcc);
                    licznik++;

                    geo.generateFileANW("plikANW.txt", xrealc, xbinc, fxcc, licznik, t);

                }
                
                measure = (double)1 / (double)licznik;
                i = 0;
                chart3.Series.Add("local" + t);
                chart3.Series["local" + t].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                for (w = measure; w <= 1; w = w + measure)
                {
                    //dodawanie lokalnych wartości do wykresu                
                    chart3.Series["local" + t].Points.AddXY((t + w), fxlocal[i]);
                    if (fxbest < fxlocal[i])
                    {
                        chart3.Series["FxBest"].Points.AddXY((t + w), fxlocal[i]);
                    }

                    i++;

                }
                fxlocal.Clear();

                if (fxbest < fxcc)
                {
                    xrealbest = xrealc;
                    fxbest = fxcc;
                    xbinbest = xbinc;
                }

                chart3.Series["FxBest"].Points.AddXY(t+1, fxbest);
            }


            //wypisywanie na okienko
            richTextBoxGEO.Text = "ANW Najlepszy wynik: \nxreal: " + xrealbest + " \nxbin: " + xbinbest + " \nfx: " + fxbest;

         }


        private void GEO_Click(object sender, EventArgs e)
        {
            //zmienne od użytkownika
            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            double d = Convert.ToDouble(textBoxD.Text);
            string dHelp = textBoxD.Text.Split(',').Last();
            double l = Math.Ceiling(Math.Log(((1 / d) * (b - a) + 1), 2)); // obliczanie l czyli na ilu bitach się liczba zmiejsci
            int T = Convert.ToInt32(textBoxT.Text);
            double tau = Convert.ToDouble(textBoxTau.Text);

            
            List<double> xreal = new List<double>();
            List<double> xrealChange = new List<double>();
            List<double> fx = new List<double>();
            List<int> xint = new List<int>();
            //List<string> xbin = new List<string>();
            string xbin;
            int i = 0;
            int counter = 0;
            //najlepsze wyniki
            double xrealbest = 0;
            double fxbest = 0;
            string xbinbest = "0";

            string xbinb;
            //wyniki po zmianie bitu
            List<string> xbinChange = new List<string>();
            //rangi
            List<int> rangs = new List<int>();
            //Losowe liczby
            List<double> randomNumbers = new List<double>();
            
            List<double> px = new List<double>();//Prawdopodobieństwo wystąpienia zmiany
            List<int> r = new List<int>(); //nadanie rang


            ConvertFromAndToDecimal convertFromAndToDecimal = new ConvertFromAndToDecimal();
            GEO geo = new GEO();

            //czyszczenie serii dla wykresu, zeby dla kazdego nowego start generował od zera
            chart2.Titles.Clear();
            chart2.Series["Fx"].Points.Clear();
            chart2.Series["FxBest"].Points.Clear();
            chart2.Titles.Add("Historia");
            counter = 0;

            xreal = InitPopulation(a, b, 1);

            do
            {
                fx = CalculateFunction(xreal);
                xint = FromXrealToXint(xreal, a, b, l);
                xbin = convertFromAndToDecimal.intToBinarty(xint[0], l);

                counter++;
                //przypisanie najlepszego wyniku
                if (fxbest < fx[0])
                {
                    xrealbest = xreal[0];
                    fxbest = fx[0];
                    xbinbest = xbin;
                    //generowanie pliku
                    geo.generateFileGEO("plikGEO.txt", xrealbest, xbinbest, fxbest, counter);
                }
                
                chart2.Series["Fx"].Points.AddXY((counter), fx[0]);
                chart2.Series["FxBest"].Points.AddXY((counter), fxbest);

                //zmiana bitów
                xbinChange.Clear();
                for (i = 0; i < xbin.Length; i++)
                {
                    xbinChange.Add(geo.changeBit(xbin, i));
                }

                //zmina z xbin -> xint aby wyznaczyć wartości funkcji
                xint.Clear();
                foreach (var item in xbinChange)    // wygenerowanie xint (xbin -> xint)
                {
                    xint.Add(convertFromAndToDecimal.convertFrom(item, 2));
                }

                xrealChange = FromXintToXreal(xint, a, b, l); //wygenerowanie z xint do xreal

                //obliczanie funkji 
                fx = CalculateFunction(xrealChange);

                //nadawanie rangi
                rangs = geo.doRang(fx);

                //obliczanie prawdopodobieństwa
                px.Clear();
                for (i = 0; i < fx.Count(); i++)
                {
                    px.Add(geo.px(i + 1, tau));
                }
                //losowanie l liczb z zakresu 0-1
                randomNumbers = RandomNumber(l);

                xbinb = "";
                for (i = 0; i < xbin.Length; i++)
                {
                    xbinb = xbinb + geo.doMutationGEO(xbin[i], randomNumbers[i], px[i]);
                }

                xint.Clear();
                xint.Add(convertFromAndToDecimal.convertFrom(xbinb, 2)); //xbin --> xint)

                xreal = FromXintToXreal(xint, a, b, l); //wygenerowanie z xint do xreal
                T--;
            } while (T > 0);


            richTextBoxGEO.Text = "GEO Najlepszy wynik: \nxreal: " + xrealbest + " \nxbin: " + xbinbest + " \nfx: " + fxbest;
        }


        //lab5
        private void AlgorytmGenetyczny_Click(object sender, EventArgs e)
        {
            //do pomiaru czasu
            Stopwatch stopWatch = new Stopwatch();
            TimeSpan ts;
            string elapsedTime;

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

            Boolean eliteChecked = checkBoxEilte.Checked;

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
            //List<double> elitefxlist = new List<double>();
           // List<double> elitexreallist = new List<double>();

            Dictionary<double, int> dict = new Dictionary<double, int>(); //do obliczania wystapien danego elementu
            
            //do wyników ostatecznych
            List<double> resultXreal = new List<double>();
            List<double> resultFx = new List<double>();
            List<double> resultOccurrence = new List<double>();

            GenerateFileModul8(a, b, d, n, T, Pk, Pm);//Generowanie pliku do modulu 8

            int j = 0;
            int el = 0;
            int elitePoint = 0;

            Lab3 lab3 = new Lab3(dHelp.Length);

            ConvertFromAndToDecimal convertFromAndToDecimal = new ConvertFromAndToDecimal();

            Lab4 lab4 = new Lab4();

            stopWatch.Start();

            xreal = InitPopulation(a, b, n); //wygenerowanie populacji xReal
                 
                
            for (int z = 0; z < T; z++)
            {
                fx = CalculateFunction(xreal); // wyliczenie funkcji f(x)

                if (eliteChecked) { 
                    if (elitefx > fx.Max())
                    {
                        //wstawianie elity 
                        elitePoint = random.Next(0, (int)n);
                        fx[el] = elitefx;
                        xreal3[el] = elitexreal;
                    }
                    else
                    {
                        //generowanie elity
                        el = 0;
                        elitefx = fx.Max();
                        foreach (var elite in fx)
                        {
                            if (fx.Max() == elite)
                            {
                                elitexreal = xreal[el];
                                break;
                            }
                            el++;
                        }
                    }
                }
                WriteGenerationForModul8(xreal, fx, elitexreal, z); //zapisywanie do pliku pokolenia

                fxmin.Add(fx.Min());
                fxmax.Add(fx.Max());
                fxavg.Add(fx.Average());

                gx = lab3.searchGx(fx, d);
                px = lab3.countPx(gx);
                qx = lab3.countQx(px);
                r = RandomNumber(n);
                xreal2 = lab3.pickXreal(xreal, qx, r, n); // populacja po selekcji 

                //4laby 

                xreal2int = FromXrealToXint(xreal2, a, b, l); //wygenerowanie xreal2int (xreal2 -> xint)
                xreal2bin.Clear();
                foreach (var item in xreal2int)    // wygenerowanie ciagu binarnego (xreal2int -> xreal2bin)
                {
                    //xreal2bin.Add(convertFromAndToDecimal.convertTo(item, 2, l));
                    xreal2bin.Add(convertFromAndToDecimal.intToBinarty(item, l));
                }

                r = RandomNumber(n);

                xParents = lab4.serachParets(xreal2bin, r, Pk);  //generowania pokolenia rodziców 

                Pc = lab4.searchSection(xParents, l);

                children = lab4.doChildren(xParents, Pc, n);
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

               // elitefxlist.Add(elitefx);
               // elitexreallist.Add(elitexreal);

                xreal = xreal3;
            }

            //czyszczenie serii dla wykresu, zeby dla kazdego nowego start generował od zera
            chart1.Titles.Clear();
            chart1.Series["FxMAX"].Points.Clear();
            chart1.Series["FxAVG"].Points.Clear();
            chart1.Series["FxMIN"].Points.Clear();

            Chart_Draw(fxmax, fxavg, fxmin);

            dict = countOccurrence(xreal3);
            
            foreach(var item in dict)
            {
                resultXreal.Add(item.Key);
        
                resultOccurrence.Add((((double)item.Value / (double)xreal.Count()) * 100));
            }

            resultFx = CalculateFunction(resultXreal);

            for (int i = 0; i < resultXreal.Count; i++)
            {
                genTable.Add(new GenerateTable(i + 1, resultXreal[i], resultFx[i], resultOccurrence[i]));
            }
            dataGridView1.DataSource = genTable;
            dataGridView1.DataSource = generateTableBindingSource;

            ((CurrencyManager)BindingContext[genTable]).Refresh();

            stopWatch.Stop();
            ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            

            //Generowanie pliku do modulu 9
            GenerateFileModul9(a, b, d, n, T, Pk, Pm, fxmax, fxavg, fxmin, elapsedTime);
        }


        //generujemy wykres Algorytm Genetyczny
        private void Chart_Draw(List<double> FxMax, List<double> FxAVG, List<double> FxMIN)
        {
            int counter = 0;
            chart1.Titles.Add("Historia");
            foreach (var item in FxMax)
            {
                chart1.Series["FxMAX"].Points.AddXY((counter+1), item);
                chart1.Series["FxAVG"].Points.AddXY((counter + 1), FxAVG[counter]);
                chart1.Series["FxMIN"].Points.AddXY((counter + 1), FxMIN[counter]);
                counter++;                               
            }
             
        }
        //generujemy plik do modulu 9
        private void GenerateFileModul9(double a, double b, double d, double n, int T, double Pk, double Pm, List<double> fxmax, List<double> fxavg, List<double> fxmin, string runTime)
        {
            string fileName = "Modul9.txt";

            string pathString = Path.Combine("", fileName);
            int counter = 0;

            if (File.Exists(pathString))
            {
                File.Delete(pathString);
            }

            using (StreamWriter file = new StreamWriter(pathString, true))
            {

                file.WriteLine("Parametry: " + "a = " + a + ", b = " + b + ", d = " + d + ", n = " + n + ", T = " + T + ", Pk = " + Pk + ", Pm = " + Pm);
                file.WriteLine("Run time: " + runTime);
                file.WriteLine("T \t fxmin \t\t\t\t fxavg \t\t\t\t fxmax");
                
                foreach (var item in fxmax)
                {
                    file.WriteLine((counter+1) + "  \t " + fxmin[counter] + " \t\t " + fxavg[counter] + " \t\t " + item);
                    counter++;
                }

            }
        }

        //Generujemy plik do modulu 8
        private void GenerateFileModul8(double a, double b, double d, double n, int T, double Pk, double Pm)
        {
            string fileName = "Modul8.txt";

            string pathString = Path.Combine("", fileName);

            
            if (File.Exists(pathString))
            {
                File.Delete(pathString);               
            }
            
            using (StreamWriter file = new StreamWriter(pathString, true))
            {
                file.WriteLine("Parametry: " + "a = " + a + ", b = " + b + ", d = " + d + ", n = " + n + ", T = " + T + ", Pk = " + Pk + ", Pm = " + Pm);
            }       
        }

        //zapisujemy pokolenia do pliku z modulu 8
        private void WriteGenerationForModul8(List<double> xreal, List<double> fx, double elite, int T)
        {
            string fileName = "Modul8.txt";

            string pathString = Path.Combine("", fileName);
            int counter = 0;
            using (StreamWriter file = new StreamWriter(pathString, true))
            {
                file.WriteLine("Pokolenie = " + (T+1));
                file.WriteLine("Lp \t xreal    \t fx");
                foreach (var item in xreal)
                {
                    file.WriteLine((counter+1) + " \t " + item + "    \t " + fx[counter]);
                    counter++;
                }
                file.WriteLine("Elita pokolenia = " + elite + "\n");
            }
        }

        private Dictionary<double, int> countOccurrence(List<double> xreal)
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


        private List<double> InitPopulation(double a, double b, double n)
        {

            List<double> randomList = new List<double>(); // lista do wylosowanych liczb
            List<double> listOfPopulation = new List<double>(); //lista populacji

            randomList = RandomNumber(n);

            string dHelp = textBoxD.Text.Split(',').Last();

            foreach (var item in randomList)
            {
                listOfPopulation.Add(Math.Round((item * (b - a) + a), dHelp.Length));//zaokroąglanie 
            }

            return listOfPopulation;
        }

        //funkcja losujaca liczby od 0-n
        private List<double> RandomNumber(double n)
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
        private List<double> CalculateFunction(List<double> xreal1)
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

        private List<int> FromXrealToXint(List<double> xreal, double a, double b, double l)
        {

            List<int> xint = new List<int>();

            foreach (var item in xreal)
            {
                xint.Add((int)((1 / (b - a)) * (item - a) * (Math.Pow(2, l) - 1)));
            }

            return xint;
        }

        private List<double> FromXintToXreal(List<int> xint, double a, double b, double l)
        {
            List<double> xreal1 = new List<double>();

            string dHelp = textBoxD.Text.Split(',').Last();

            foreach (var item in xint)
            {
                xreal1.Add(Math.Round((((b - a) * item) / (Math.Pow(2, l) - 1) + a), dHelp.Length));
            }
            return xreal1;
        }

    }
}
