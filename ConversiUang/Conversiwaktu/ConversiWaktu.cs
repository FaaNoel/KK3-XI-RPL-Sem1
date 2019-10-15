using System;

namespace Conversiwaktu
{
    public class ConversiWaktu
    {
        public double conversi1()
        {
            Console.WriteLine("Masukkan nilai Rupiah :");
            double angka1 = double.Parse(Console.ReadLine());


            double rupidol = angka1 * 0.00071;
            Console.WriteLine("Hasil conversi dari Rupiah ke Dollar" + angka1 + "dan" + 14000 + "adalah");


            return rupidol;
        }
        public double conversi2()
        {
            Console.WriteLine("Masukkan nilai Dollar :");
            double angka2 = double.Parse(Console.ReadLine());


            double dolrupi = angka2 * 14247.30;
            Console.WriteLine("Hasil conversi dari Rupiah ke Dollar" + angka2 + "dan" + 14000 + "adalah");


            return dolrupi;
        }
        public double conversi3()
        {
            Console.WriteLine("Masukkan nilai Rupiah :");
            double angrup = double.Parse(Console.ReadLine());
            double dolrupi = angrup * 85158;
            Console.WriteLine("Hasil conversi dari Rupiah ke Won adalah :" + angrup);


            return dolrupi;

        }
        public double conversi4()
        {
            Console.WriteLine("Masukkan nilai Won:");
            double nilai = double.Parse(Console.ReadLine());
            double hasil = nilai * 117429;
            Console.WriteLine("Hasil conversi dari Won ke Rupiah adalah :" + hasil);
            return hasil;

        }
        public double conversi5()
        {
            Console.WriteLine("Masukkan nilai Rupiah:");
            double nilai = double.Parse(Console.ReadLine());
            double hasil = nilai * 7.396;
            Console.WriteLine("Hasil conversi dari Rupiah ke Yen adalah :" + hasil);
            return hasil;

        }
        public double conversi6()
        {
            Console.WriteLine("Masukkan nilai Yen:");
            double nilai = double.Parse(Console.ReadLine());
            double hasil = nilai * 135.2;
            Console.WriteLine("Hasil conversi dari Yen ke Rupiah adalah :" + hasil);
            return hasil;

        }
        public double conversi7()
        {
            Console.WriteLine("Masukkan nilai Rupiah:");
            double nilai = double.Parse(Console.ReadLine());
            double hasil = nilai * 0.057;
            Console.WriteLine("Hasil conversi dari Rupiah ke Poundsterling adalah :" + hasil);
            return hasil;

        }
        public double conversi8()
        {
            Console.WriteLine("Masukkan nilai Poundsterling:");
            double nilai = double.Parse(Console.ReadLine());
            double hasil = nilai * 17500;
            Console.WriteLine("Hasil conversi dari Poundsterling ke Rupiah adalah :" + hasil);
            return hasil;

        }
        public double conversi9()
        {
            Console.WriteLine("Masukkan nilai Rupiah:");
            double nilai = double.Parse(Console.ReadLine());
            double hasil = nilai * 0.263;
            Console.WriteLine("Hasil conversi dari Rupiah ke Riyal adalah :" + hasil);
            return hasil;

        }
        public double conversi10()
        {
            Console.WriteLine("Masukkan nilai Riyal:");
            double nilai = double.Parse(Console.ReadLine());
            double hasil = nilai * 3800;
            Console.WriteLine("Hasil conversi dari Riyal ke Rupiah adalah :" + hasil);
            return hasil;

        }

    }
}
