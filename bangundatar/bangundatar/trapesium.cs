using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bangundatar
{
    class trapesium
    {
        private double alas;
        private double alasatas;
        private double sm;
        private double tinggi;
        private double luas;
        private double keliling;
        public double setalastrapesium()
        {
            Console.WriteLine("Masukan alas trapesium sama kaki : ");
            double xalas = double.Parse(Console.ReadLine());
            alas += xalas;
            return alas;
        }
        public double setalasatastrapesium()
        {
            Console.WriteLine("Masukan alas atas trapesium sama kaki : ");
            double xalasatas = double.Parse(Console.ReadLine());
            alasatas += xalasatas;
            return alasatas;
        }
        public double setsisimiringtrapesium()
        {
            Console.WriteLine("Masukan sisi miring trapesium sama kaki : ");
            double xsm = double.Parse(Console.ReadLine());
            sm += xsm;
            return sm;
        }

        public double settinggitrapesium()
        {
            Console.WriteLine("Masukan tinggi trapesium : ");
            double xtinggi = double.Parse(Console.ReadLine());
            tinggi += xtinggi;
            return tinggi;
        }

        public double setluastrapesim()
        {
            luas = (alas + alasatas) * tinggi / 2;
            Console.WriteLine("Luas trapesium sama kaki : " + luas);
            return luas;
        }
        public double setkelilingtrapesium()
        {
            keliling = alas + alasatas + 2 * sm;
            Console.WriteLine("Keliling trapesium sama kaki : " + keliling);
            return keliling;
        }
    }
}
