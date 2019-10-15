using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bangundatar
{
    class persegi
    {
        private double sisi;
        private double luas;
        private double keliling;
        public double setsisipersegi()
        {
            Console.WriteLine("Masukan sisi persegi : ");
            double xsisi = double.Parse(Console.ReadLine());
            sisi += xsisi;
            return xsisi;
        }

        public double setluaspersegi()
        {
            luas = sisi * sisi;
            Console.WriteLine("Luas Persegi : " + luas);
            return luas;
        }
        public double setkeliling()
        {
            keliling = 4 * sisi;
            Console.WriteLine("Keliling Persegi : " + keliling);
            return keliling;
        }
    }
}
