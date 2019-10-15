using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kocheng
{
    class Kucing
    {
        string nama;
        string ras;
        int umur;

        public void jalan()
        {
            Console.WriteLine("Kucing Berjalan Dengan 4 Kaki");
        }
        static void Main(string[] args)
        {
            Kucing spinx = new Kucing();
            Kucing persia = new Kucing();
            Kucing himalaya = new Kucing();

            spinx.nama = "Kucing Spinx";
            spinx.ras = "kocheng";
            spinx.umur = 7;

            persia.nama = "Kucing Persia";
            persia.ras = "Kocheng";
            persia.umur = 5;

            himalaya.nama = "Kucing Himalaya";
            himalaya.ras = "Kocheng";
            himalaya.umur = 6;

            Console.WriteLine("Nama : " + spinx.nama);
            Console.WriteLine("Ras : " + spinx.ras);
            Console.WriteLine("Umur : " + spinx.umur + "Tahun");

            Console.WriteLine("Nama : " + persia.nama);
            Console.WriteLine("Ras : " + persia.ras);
            Console.WriteLine("Umur : " + persia.umur + "Tahun");

            Console.WriteLine("Nama : " + himalaya.nama);
            Console.WriteLine("Ras : " + himalaya.ras);
            Console.WriteLine("Umur : " + himalaya.umur + "Tahun");

            Console.ReadKey();

        }

    }
}
