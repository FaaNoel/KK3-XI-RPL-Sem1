using System;
using konversi_panjang;

namespace aksespanjang
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 konversi = new Class1(10, 1000, 1000, 10, 1000);
            konversi.meterTodm();
            konversi.meterTocm();
            konversi.meterTomm();
            konversi.kiloTohm();
            konversi.kmTom();


            Console.ReadLine();
        }
    }
}
