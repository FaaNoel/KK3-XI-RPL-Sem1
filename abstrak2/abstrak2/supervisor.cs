using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrak2
{
    class supervisor : perusahaanrokok
    {
        public override double experienceyear()
        {
            Console.WriteLine("Masukan experienceyear anda : ");
            double xexperience = double.Parse(Console.ReadLine());
            Console.WriteLine("Experience year anda = " + xexperience);
            return xexperience;
        }

        public override double gaji()
        {
            double xgaji = 15000000;
            Console.WriteLine("gaji anda = " + xgaji + "rupiyah");
            return xgaji;
        }

        public override void licence()
        {
            Console.WriteLine("Licence = Lulus SMA/SMK Sederajat");   
        }

        public override void sertification()
        {
            Console.WriteLine("Sertification = Ijazah SMA?SMK");   
        }

        public override void merokok()
        {
            Console.WriteLine("Merokok = Boleh Merokok");
        }

        public override void siftworking()
        {
            Console.WriteLine("SiftW = Senin Rabu");
        }

        public override double cuti()
        {
            Console.WriteLine("Masukan cuti anda : ");
            double xcuti = double.Parse(Console.ReadLine());
            Console.WriteLine("Cuti anda = " + xcuti);
            return xcuti;
        }

        public override void resign()
        {
            Console.WriteLine("Boleh Resign");
        }
    }
}
