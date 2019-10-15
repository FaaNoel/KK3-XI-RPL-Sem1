using System;

namespace ConversiWaktu
{
    public class ConversiWaktu
    {
        public double conversi1()
        {
            Console.WriteLine("Masukkan Menit:");
            double nilai = double.Parse(Console.ReadLine());
            double hasil = nilai * 60;
            Console.WriteLine("Hasil conversi dari Riyal ke Rupiah adalah :" + hasil);
            return hasil;

        }

        public double conversi2()
        {
            Console.WriteLine("Masukkan Jam:");
            double nilai = double.Parse(Console.ReadLine());
            double hasil = nilai * 3600;
            Console.WriteLine("Hasil conversi dari Riyal ke Rupiah adalah :" + hasil);
            return hasil;

        }
        public double conversi3()
        {
            Console.WriteLine("Masukkan Hari:");
            double nilai = double.Parse(Console.ReadLine());
            double hasil = nilai * 86400;
            Console.WriteLine("Hasil conversi dari Riyal ke Rupiah adalah :" + hasil);
            return hasil;

        }
        public double conversi4()
        {
            Console.WriteLine("Masukkan Minggu:");
            double nilai = double.Parse(Console.ReadLine());
            double hasil = nilai * 604800;
            Console.WriteLine("Hasil conversi dari Riyal ke Rupiah adalah :" + hasil);
            return hasil;

        }
        public double conversi5()
        {
            Console.WriteLine("Masukkan Bulan:");
            double nilai = double.Parse(Console.ReadLine());
            double hasil = nilai * 2628002.88;
            Console.WriteLine("Hasil conversi dari Riyal ke Rupiah adalah :" + hasil);
            return hasil;

        }

    }
}
