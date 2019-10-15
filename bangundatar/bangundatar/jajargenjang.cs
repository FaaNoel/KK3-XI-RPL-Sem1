using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bangundatar
{
    class jajargenjang
    {
        private double alas;
        private double sm;
        private double tinggi;
        private double luas;
        private double keliling;
        public double setalasjajargenjang()
        {
            Console.WriteLine("Masukan alasjajargenjang : ");
            double xalas = double.Parse(Console.ReadLine());
            alas += xalas;
            return alas;
        }
        public double setsisimiringjajargenjang()
        {
            Console.WriteLine("Masukan sisi miring jajargenjang : ");
            double xsm = double.Parse(Console.ReadLine());
            sm += xsm;
            return sm;
        }
        public double settinggijajargenjang()
        {
            Console.WriteLine("Masukan tinggi jajargenjang : ");
            double xtinggi = double.Parse(Console.ReadLine());
            tinggi += xtinggi;
            return tinggi;
        }
        public double setluasjajargenjang()
        {
            luas = alas * tinggi;
            Console.WriteLine("Luas jajargenjang : " + luas);
            return luas;
        }
        
        public double setkelilingjajargenjang()
        {
            keliling = 2 * (alas + sm);
            Console.WriteLine("Keliling jajargenjang : " + keliling);
            return keliling;
        }
    }
}
