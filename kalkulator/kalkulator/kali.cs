using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class kali : jumlah
    {
        private double angka1;
        private double angka2;

        public override double setangka1()
        {
            Console.WriteLine("Masukan angka pertama : ");
            angka1 = double.Parse(Console.ReadLine());
            return angka1;
        }

        public override double setangka2()
        {
            Console.WriteLine("Masukan angka kedua : ");
            angka2 = double.Parse(Console.ReadLine());
            return angka2;
        }

        public override double sethasil()
        {
            double hasil = angka1 * angka2;
            Console.WriteLine("Hasil pengkalian = " + hasil);
            return hasil;
        }
    }
}
