using System;

namespace Suhu
{
    class Program
    {
        static void Main(string[] args)
        {
            Suhu shu = new Suhu(273.15, -273.15, 32, -459.7, 8535);
            shu.celciusfahrenheit();
            shu.kelvincelcius();
            shu.celciusfahrenheite();
            shu.kelvinfahrenheit();
            shu.fahrenheitkelvin();


            Console.ReadLine();
        }
    }
}
