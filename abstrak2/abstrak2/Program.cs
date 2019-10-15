using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrak2
{
    class Program
    {
        static void Main(string[] args)
        {
            supervisor supervisor1 = new supervisor();
            Console.WriteLine("Supervisor");
            supervisor1.gaji();
            supervisor1.licence();
            supervisor1.sertification();
            supervisor1.experienceyear();
            supervisor1.cuti();
            supervisor1.merokok();
            supervisor1.siftworking();
            supervisor1.resign();

            enginer enginer1 = new enginer();
            Console.WriteLine("Enginer");
            enginer1.gaji();
            enginer1.licence();
            enginer1.sertification();
            enginer1.experienceyear();
            enginer1.cuti();
            enginer1.merokok();
            enginer1.siftworking();
            enginer1.resign();

            Console.ReadLine();

        }
    }
}
