using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrak
{
    class siswa : school
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
            Console.WriteLine("Siswa dilarang merokok");
        }

        public override void Berprestasi()
        {
            Console.WriteLine("Siswa diharapkan bisa berprestasi");
        }

        public override void Makandikantin()
        {
            Console.WriteLine("Siswa boleh makan di kantin");
        }

        public override void Berkreasi()
        {
            Console.WriteLine("Siswa boleh berkreasi semaunya");
        }

        public override void Demonstrasi()
        {
            Console.WriteLine("Siswa boleh demonstrasi");
        }
    }
}
