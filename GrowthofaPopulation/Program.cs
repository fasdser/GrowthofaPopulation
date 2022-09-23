using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowthofaPopulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NbYear(2000000, 0, 10000, 2000000));
            Console.ReadKey();
        }

        public static int NbYear(int p0, double percent, int aug, int p)
        {

            //int result = 0;
            percent /= 100;

          
            int end = (int)(p0 * percent) + aug;
            int n = 0;
            for (int i = p0; i <= p; i += end)
            {
                p0 = i;
                end = (int)(p0 * percent) + aug;
                n++;
            }
            if (p0 == p)
            {
                return n-1;
            }
            Console.WriteLine($"начале года = {p0}\nрегулярно уv = {percent}\nгород приезжает = {aug}\nстало больше или равно = {p}");
            Console.WriteLine(n);
            return n;
        }

        public static int NbYear1(int p0, double percent, int aug, int p)
        {
            int year;
            for (year = 0; p0 < p; year++)
                p0 += (int)(p0 * percent / 100) + aug;
            return year;
        }

        public static int NbYear2(int p0, double percent, int aug, int p)
        {
            return p0 >= p ? 0 : 1 + NbYear2((int)(p0 + p0 * percent / 100 + aug), percent, aug, p);
        }

        public static int NbYear3(int p0, double percent, int aug, int p)
        {
            int rs = 0;
            while (p0 < p)
            {
                rs++;
                p0 += (int)(p0 * percent / 100) + aug;
            }
            return rs;
        }
    }
}
