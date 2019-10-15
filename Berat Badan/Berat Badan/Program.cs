using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berat_Badan
{
    class bbd
    {
        public int tinggi;
        public string gender;
        public string nama;

        public int beratbadanidealWanita()
        {
            int badanideal = tinggi - 100 - ((tinggi - 100) * 15 / 100);
            return badanideal;
        }
        public int beratbadanidealPria()
        {
            int badanideal = tinggi - 100 - ((tinggi - 100) * 10 / 100);
            return badanideal;
        }
        public void tampil()
        {
            Console.Write("Masukan Jenis Kelamin Anda(P/W) : ");
            gender = Console.ReadLine();
            if ((gender == "P") || (gender == "p"))
            {
                Console.Write("Masukan Nama Anda = ");
                nama = Console.ReadLine();
                Console.Write("Masukan Tinggi Anda = ");
                tinggi = int.Parse(Console.ReadLine());
                Console.Write("Berat Badan Ideal Anda = " + beratbadanidealPria());
            }
            else if ((gender == "W") || (gender == "w"))
            {
                Console.WriteLine("Masukan Nama Anda = ");
                nama = Console.ReadLine();
                Console.WriteLine("Masukan Tinggi Anda = ");
                tinggi = int.Parse(Console.ReadLine());
                Console.WriteLine("Berat Badan Ideal Anda = " + beratbadanidealWanita());
            }
            {

            }

        }
        static void Main(string[] args)
        {
            bbd beratbadanid = new bbd();
            beratbadanid.tampil();

            Console.ReadKey();

               
        }
    }
}
