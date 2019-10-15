using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tukar_jarak
{
    class tukarkm
    {
        private double jumlahkm;
        private double hasilmeter;

        public double setjumlahkm()
        {
            Console.WriteLine("Masukan jumlah jarak km :");
            jumlahkm = double.Parse(Console.ReadLine());
            return jumlahkm;
        }

        public virtual double sethasilmeter()
        {
            hasilmeter = jumlahkm * 1000;
            Console.WriteLine("nilai meter anda adalah " + hasilmeter);
            return hasilmeter;
        }
    }
}
