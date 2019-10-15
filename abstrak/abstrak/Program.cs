using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrak
{
    class Program
    {
        static void Main(string[] args)
        {
            siswa siswa1 = new siswa();

            Console.WriteLine("Siswa----");
            siswa1.nosmoking();
            siswa1.nodrugs();
            siswa1.nocorruption();
            siswa1.Berprestasi();
            siswa1.Makandikantin();
            siswa1.Berkreasi();
            siswa1.Demonstrasi();

            karyawan karyawan1 = new karyawan();
            Console.WriteLine("Karyawan----");
            karyawan1.nosmoking();
            karyawan1.nodrugs();
            karyawan1.nocorruption();
            karyawan1.Makandikantin();
            karyawan1.Demonstrasi();

            guru guru1 = new guru();
            Console.WriteLine("Guru----");
            guru1.nosmoking();
            guru1.nodrugs();
            guru1.nocorruption();
            guru1.Makandikantin();
            guru1.Berkreasi();
            guru1.Demonstrasi();

            Console.ReadLine();

        }
    }
}
