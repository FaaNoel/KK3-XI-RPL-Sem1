using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tukar_jarak
{
    class tukarmil : tukarkm
    {
        private double jumlahmil;
        private double hasilmeter;

        public double setjumlahmil()
        {
            Console.WriteLine("Masukan jumlah jarak mil : ");
            jumlahmil = double.Parse(Console.ReadLine());
            return jumlahmil;
        }

        public override double sethasilmeter()
        {
            hasilmeter = jumlahmil * 15609.34;
            Console.WriteLine("nilai meter anda adalah " + hasilmeter);
            return hasilmeter;
        }
    }
}
