using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrak2
{
    abstract class perusahaanrokok
    {
        public abstract double gaji();

        public abstract void sertification();

        public abstract double experienceyear();

        public abstract void licence();

        public virtual void merokok()
        {

        }

        public virtual void siftworking()
        {

        }

        public virtual double cuti()
        {
            Console.WriteLine("Masukan cuti anda : ");
            double xcuti = double.Parse(Console.ReadLine());
            return xcuti;
        }

        public virtual void resign()
        {

        }
    }
}
