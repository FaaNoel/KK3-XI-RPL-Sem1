using System;
using System.Collections.Generic;
using System.Text;

namespace KalkulatorConstructor
{
    class Kalkulator
    {
        public int angka1, angka2;
        public Kalkulator(int ang1, int ang2) 
        {
            this.angka1 = ang1;
            this.angka2 = ang2;
        }
        public double penjumlahan()
        {
            double jumlah = angka1 + angka2;
            Console.WriteLine("Hasil" + angka1 + "+" + angka2 + "=" + jumlah );
            return jumlah;
        }
        public double pembagian()
        {
            double jumlah = angka1 / angka2;
            Console.WriteLine("Hasil" + angka1 + "+" + angka2);
            return jumlah;
        }
        public double perkalian()
        {
            double jumlah = angka1 * angka2;
            Console.WriteLine("Hasil" + angka1 + "+" + angka2);
            return jumlah;
        }
        public double pengurangan()
        {
            double jumlah = angka1 - angka2;
            Console.WriteLine("Hasil" + angka1 + "+" + angka2);
            return jumlah;
        }


    } //instance of the class constructor, tidak memiliki parameter
    // constructor parameter dan non parameter 
}
