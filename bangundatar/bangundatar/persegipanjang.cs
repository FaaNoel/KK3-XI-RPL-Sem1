using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bangundatar
{
    class persegipanjang
    {
        private double panjang;
        private double lebar;
        private double luas;
        private double keliling;
        public double setpanjangpersegipanjang()
        {
            Console.WriteLine("Masukan panjang persegi panjang : ");
            double xpanjang = double.Parse(Console.ReadLine());
            panjang += xpanjang;
            return panjang;
        }

        public double setlebarpersegipanjang()
        {
            Console.WriteLine("Masukan lebar persegi panjang : ");
            double xlebar = double.Parse(Console.ReadLine());
            lebar += xlebar;
            return lebar;
        }

        public double setluaspersegipanjang()
        {
            luas = panjang * lebar;
            Console.WriteLine("Luas Persegi panjang : " + luas);
            return luas;
        }

        public double setkelilingpersegipanjang()
        {
            keliling = 2 * panjang + lebar;
            Console.WriteLine("Keliling Persegi panjang : " + keliling);
            return keliling;
        }
    }
}
