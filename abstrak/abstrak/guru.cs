using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrak
{
    class guru : school
    {

        

        public override void nodrugs()
        {
            Console.WriteLine("Tidak boleh memakai narkoba");
        }
        public override void nocorruption()
        {
            Console.WriteLine("Tidak boleh korupsi");
        }

        public override void nosmoking()
        {
            Console.WriteLine("Guru dilarang merokok");
        }

        public override void Makandikantin()
        {
            Console.WriteLine("Guru boleh makan di kantin");
        }

        public override void Demonstrasi()
        {
            Console.WriteLine("Guru boleh demonstrasi");
        }

        public override void Berkreasi()
        {
            Console.WriteLine("Guru boleh berkreasi dalam mengajar");   
        }
    }
}
