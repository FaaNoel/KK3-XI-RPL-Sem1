using System;
using System.Collections.Generic;
using System.Text;

namespace Suhu
{
    class Suhu
    {
        public double cf, kc, cft, kf, fk;

        public Suhu(double cefa, double kece, double kefa, double cefah, double fake)
        {
            this.cf = cefa;
            this.kc = kece;
            this.cft = cefah;
            this.kf = kefa;
            this.fk = fake;

        }
        public double celciusfahrenheit()
        {
            Console.WriteLine ("Masukkan inputtan (Celcius) :");
            double chf = double.Parse(Console.ReadLine());
            double hasil = chf * cf;
            Console.WriteLine("Hisil Konversi" + chf + "Celcius ke Fahrenheit adalah :" + hasil);
            return chf;
        }

        public double kelvincelcius()
        {
            Console.WriteLine ("Masukkan inputtan (Kelvin) :");
            double chf = double.Parse(Console.ReadLine());
            double hasil = chf * kc;
            Console.WriteLine("Hisil Konversi" + chf + "Kelvin ke Celcius adalah :" + hasil);
            return chf;
        }

        public double celciusfahrenheite()
        {
            Console.WriteLine ("Masukkan inputtan (Celcius) :");
            double chf = double.Parse(Console.ReadLine());
            double hasil = chf * cft;
            Console.WriteLine("Hisil Konversi" + chf + "Celcius ke Fahrenheit adalah :" + hasil);
            return chf;
        }
        public double kelvinfahrenheit()
        {
            Console.WriteLine ("Masukkan inputtan (Kelvin) :");
            double chf = double.Parse(Console.ReadLine());
            double hasil = chf * kf;
            Console.WriteLine("Hisil Konversi" + chf + "Kelvin ke Fahrenheit adalah :" + hasil);
            return chf;
        }
        public double fahrenheitkelvin()
        {
            Console.WriteLine ("Masukkan inputtan (Fahrenheit) :");
            double chf = double.Parse(Console.ReadLine());
            double hasil = chf * fk;
            Console.WriteLine("Hisil Konversi" + chf + "Fahrenheit ke Kelvin adalah :" + hasil);
            return chf;
        }



    }
}
