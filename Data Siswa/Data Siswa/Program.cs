using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Siswa
{
    class Siswa
    {
        static void Main(string[] args)
        {
            //bikin object
            // namakelas namaobject = new namakelas();

            siswa siswa1 = new siswa();
            Console.WriteLine("masukan nama anda : ");
            siswa1.nama = Console.ReadLine();
            Console.WriteLine("masukan umur anda : ");
            siswa1.umur = int.Parse(Console.ReadLine());
            Console.WriteLine("masukan alamat anda : ");
            siswa1.alamat = Console.ReadLine();

            Console.WriteLine(siswa1.nama);
            Console.WriteLine(siswa1.umur);
            Console.WriteLine(siswa1.alamat);

            Console.ReadKey();
        }
    }
}
