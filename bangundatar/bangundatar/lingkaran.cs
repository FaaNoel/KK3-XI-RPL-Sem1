using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bangundatar
{
    class lingkaran
    {
        private double phi = 3.14;
        private double r;
        private double luas;
        private double keliling;
        public double setjarijarilingkaran()
        {

            Console.WriteLine("Masukan jari jari lingkaran : ");
            double xr = double.Parse(Console.ReadLine());
            r += xr;
            return r;
        }
        public double setluaslingkaran()
        {
            luas = phi * r * r;
            Console.WriteLine("Luas Lingkaran : " + luas);
            return luas;
        }
        public double setkelilinglingkaran()
        {
            keliling = 2 * phi * r;
            Console.WriteLine("Keliling Lingkaran : " + keliling);
            return keliling;
        }
    }
}
