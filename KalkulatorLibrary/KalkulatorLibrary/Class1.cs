using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KalkulatorLibrary
{
    public class Class1
    {
        public double pengurangan()
        {
            Console.WriteLine("Masukkan Angka 1 :");
            double angka1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan Angka 2 :");
            double angka2 = double.Parse(Console.ReadLine());

            double jumlah = angka1 - angka2;
            Console.WriteLine("Hasil" + angka1 + "dan" + angka2 + "adalah");


            return jumlah;
        }

        public double penjumlahan()
        {
            Console.WriteLine("Masukkan Angka 1 :");
            double angka1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan Angka 2 :");
            double angka2 = double.Parse(Console.ReadLine());

            double jumlah = angka1 + angka2;
            Console.WriteLine("Hasil " + angka1 + "dan" + angka2 + "adalah");


            return jumlah;
        }

        public double pembagian()
        {
            Console.WriteLine("Masukkan Angka 1 :");
            double angka1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan Angka 2 :");
            double angka2 = double.Parse(Console.ReadLine());

            double jumlah = angka1 / angka2;
            Console.WriteLine("Hasil " + angka1 + "dan" + angka2 + "adalah");


            return jumlah;
        }

        public double perkalian()
        {
            Console.WriteLine("Masukkan Angka 1 :");
            double angka1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan Angka 2 :");
            double angka2 = double.Parse(Console.ReadLine());

            double jumlah = angka1 * angka2;
            Console.WriteLine("Hasil" + angka1 + "dan" + angka2 + "adalah");


            return jumlah;
        }
    }
}
