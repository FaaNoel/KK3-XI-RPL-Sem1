using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangun_Ruang
{
    class Program
    {
        static void Main(string[] args)
        {
            kubus kubus1 = new kubus();
            kubus1.setsisi();
            kubus1.setvolumekubus();
            kubus1.setluaspermukaan();

            Console.ReadKey();
        }
    }
}
