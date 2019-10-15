using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class bagi 
    {
        private int angka1;
        private int angka2;

        public int setangka1()
        {
            Console.WriteLine("Masukan angka pertama : ");
            angka1 = int.Parse(Console.ReadLine());
            return angka1;
        }

        public int setangka2()
        {
            Console.WriteLine("Masukan angka kedua : ");
            angka2 = int.Parse(Console.ReadLine());
            return angka2;
        }

        public int sethasil()
        {
            int hasil = angka1 / angka2;
            Console.WriteLine("Hasil pembagian = " + hasil);
            return hasil;
        }
    }
}
