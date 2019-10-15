using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tukar_jarak
{
    class tukarhektar : tukarkm
    {
        private double jumlahhektar;
        private double hasilmeter;

        public double setjumlahhektar()
        {
            Console.WriteLine("Masukan jumlah jarak hektar  : ");
            jumlahhektar = double.Parse(Console.ReadLine());
            return jumlahhektar;
        }

        public override double sethasilmeter()
        {
            hasilmeter = jumlahhektar * 1000;
            Console.WriteLine("nilai meter anda adalah " + hasilmeter);
            return hasilmeter;
        }
    }
}
