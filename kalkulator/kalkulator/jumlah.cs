using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class jumlah
    {
        private double angka1;
        private double angka2;

        public virtual double setangka1()
        {
            Console.WriteLine("Masukan angka pertama : ");
            angka1 = double.Parse(Console.ReadLine());
            return angka1;
        }

        public virtual double setangka2()
        {
            Console.WriteLine("Masukan angka kedua : ");
            angka2 = double.Parse(Console.ReadLine());
            return angka2;
        }

        public virtual double sethasil()
        {
            double hasil = angka1 + angka2;
            Console.WriteLine("Hasil penjumlahan = " + hasil);
            return hasil;
        }
    }
}
