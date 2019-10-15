using System;

namespace RumahTangga
{
    class Program
    {
        static void Main(string[] args)
        {
            supervisor supervisor1 = new supervisor();
            supervisor1.gaji();
            supervisor1.license();
            supervisor1.experienceyear();
            supervisor1.sertification();

            
            engineer engineer1 = new engineer();
            engineer1.gaji();
            engineer1.license();
            engineer1.experienceyear();
            engineer1.sertification();

            Console.ReadLine();

        }
    }
}
