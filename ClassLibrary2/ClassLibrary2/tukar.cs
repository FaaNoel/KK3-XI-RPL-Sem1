using System;

namespace ClassLibrary2
{
    public class tukar
    {
        public double mdm, mcm, mmm, kmhm, kmm;

        public tukar(double mtodm, double mtocm, double mtomm, double kmtohm, double kmtom)
        {
            this.mdm = mtodm;
            this.mcm = mtocm;
            this.mmm = mtomm;
            this.kmhm = kmtohm;
            this.kmm = kmtom;
        }
        public double meterTodm()
        {
            Console.WriteLine("Masukkan inputtan (Meter) :");
            double mdm = double.Parse(Console.ReadLine());
            double hasil = mdm * 10;
            Console.WriteLine("Hisil Konversi" + mdm + "M ke DM adalah :" + hasil);
            return hasil;
        }

        public double meterTocm()
        {
            Console.WriteLine("Masukkan inputtan (Meter) :");
            double mcm = double.Parse(Console.ReadLine());
            double hasil = mcm * 1000;
            Console.WriteLine("Hisil Konversi" + mcm + "M ke CM adalah :" + hasil);
            return hasil;
        }
        public double meterTomm()
        {
            Console.WriteLine("Masukkan inputtan (Meter) :");
            double kmhm = double.Parse(Console.ReadLine());
            double hasil = kmhm * 1000;
            Console.WriteLine("Hisil Konversi" + kmhm + "M ke MM adalah :" + hasil);
            return hasil;
        }
        public double kiloTohm()
        {
            Console.WriteLine("Masukkan inputtan (Kilometer) :");
            double mdm = double.Parse(Console.ReadLine());
            double hasil = mdm * 10;
            Console.WriteLine("Hisil Konversi" + mdm + "Kilometer ke HM adalah :" + hasil);
            return hasil;
        }
        public double kmTom()
        {
            Console.WriteLine("Masukkan inputtan (Meter) :");
            double kmm = double.Parse(Console.ReadLine());
            double hasil = kmm * 1000;
            Console.WriteLine("Hisil Konversi" + mdm + "KM ke M adalah :" + hasil);
            return hasil;
        }
    }
}
