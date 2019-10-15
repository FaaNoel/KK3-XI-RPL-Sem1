using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tukar_jarak
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                tukarkm tukarkm1 = new tukarkm();
                tukarkm1.setjumlahkm();
                tukarkm1.sethasilmeter();

                tukarmil tukarmil1 = new tukarmil();
                tukarmil1.setjumlahmil();
                tukarmil1.sethasilmeter();

                tukarhektar tukarhektar1 = new tukarhektar();
                tukarhektar1.setjumlahhektar();
                tukarmil1.sethasilmeter();
            }
            catch (FormatException)
            {
                Console.WriteLine("Inputtan salah, umur kan harusnya angka, lu malah huruf gimana sih ?!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Tidak bisa input 0 pada pembagian");
            }
            finally
            {
                Console.WriteLine("Terimakasih sudah mencoba");
            }
            Console.ReadLine();
        }
    }
}
