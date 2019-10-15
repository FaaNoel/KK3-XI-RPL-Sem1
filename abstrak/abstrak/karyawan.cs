using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrak
{
    class karyawan : school
    {

        public override void nocorruption()
        {
            Console.WriteLine("Tidak boleh korupsi");
        }

        public override void nodrugs()
        {
            Console.WriteLine("Tidak boleh memakai narkoba");
        }

        public override void nosmoking()
        {
            Console.WriteLine("Guru dilarang merokok");
        }

        public override void Makandikantin()
        {
            Console.WriteLine("Karyawan boleh makan di kantin");
        }

        public override void Demonstrasi()
        {
            Console.WriteLine("Karyawan boleh demonstrasi");
        }
    }
}
