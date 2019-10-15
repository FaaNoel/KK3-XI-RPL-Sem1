using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bangundatar
{
    class belah_ketupat
    {
        private double sisi;
        private double d1;
        private double d2;
        private double luas;
        private double keliling;
        public double setsisibelahketupat()
        {
            Console.WriteLine("Masukan sisi belah ketupat : ");
            double xsisi = double.Parse(Console.ReadLine());
            sisi += xsisi;
            return sisi;
        }
        public double setd1belahketupat()
        {
            Console.WriteLine("Masukan diagonal 1 atas belah ketupat : ");
            double xd1 = double.Parse(Console.ReadLine());
            d1 += xd1;
            return d1;
        }

        public double setd2belahketupat()
        {
            Console.WriteLine("Masukan diagonal 2 miring belah ketupat : ");
            double xd2 = double.Parse(Console.ReadLine());
            d2 += xd2;
            return d2;
        }
        
        public double setluasbelahketupat()
        {
            luas = 0.5 * d1 * d2;
            Console.WriteLine("Luas trapesium sama kaki : " + luas);
            return luas;
        }
        
        public double setkelilingbelahketupat()
        {
            keliling = sisi * 4;
            Console.WriteLine("Keliling trapesium sama kaki : " + keliling);
            return keliling;
        }
    }
}
