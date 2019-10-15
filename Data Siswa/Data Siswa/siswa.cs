using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Siswa
{
    class siswa
    {
        //atribut = sesuatu yang dimiliki class/object
        public string nama;
        public int umur;
        public string alamat;
        
        //method = sesuatu yang bisa dilakukan oleh class object

        //1. method void = method yang tidak ada pengembalian data/ digunakan untuk menampilkan sesuatu
        public void makan()
        {
            Console.WriteLine("makan pake tahu");
        }

        public int jumlah(int x, int y)
        {
            int hasil = x + y;
            Console.WriteLine(hasil);
            return hasil;
        }

        //2. method tipe data / method non-void : method yang memiliki pengembalian data


    }
}
