using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bangundatar
{
    class segitiga
    {
        private double alas;
        private double tinggi;
        private double sm;
        private double luas;
        private double keliling;
        public double setalassegitiga()
        {
            Console.WriteLine("Masukan alas segitiga: ");
            double xalas = double.Parse(Console.ReadLine());
            alas += xalas;
            return alas;
        }

        public double settinggisegitiga()
        {
            Console.WriteLine("Masukan tinggi segitiga : ");
            double xtinggi = double.Parse(Console.ReadLine());
            tinggi += xtinggi;
            return tinggi;
        }

        public double setsisimiringsegitiga()
        {
            Console.WriteLine("Masukan sisi miring : ");
            double xsm = double.Parse(Console.ReadLine());
            sm += xsm;
            return sm;
        }

        public double setluassegitiga()
        {
            luas = 0.5 * alas * tinggi;
            Console.WriteLine("Luas Segitiga : " + luas);
            return luas;
        }
        
        public double setkelilingsegitiga()
        {
            keliling = sm + alas + tinggi;
            Console.WriteLine("Keliling Segitiga : " + keliling);

            return keliling;
        }
    }
}
