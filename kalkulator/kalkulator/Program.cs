using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            jumlah jumlah1 = new jumlah();
            kurang kurang1 = new kurang();
            bagi bagi1 = new bagi();
            kali kali1 = new kali();
            try
            {
                jumlah1.setangka1();
                jumlah1.setangka2();
                jumlah1.sethasil();
                kurang1.setangka1();
                kurang1.setangka2();
                kurang1.sethasil();
                kali1.setangka1();
                kali1.setangka2();
                kali1.sethasil();
                bagi1.setangka1();
                bagi1.setangka2();
                bagi1.sethasil();

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Tidak bisa pembagian dengan angka 0");
            }

            catch (FormatException)
            {
                Console.WriteLine("Inputtan salah, umur kan harusnya angka, lu malah huruf gimana sih ?!");
            }

            finally
            {
                Console.WriteLine("Terimakasih sudah mencoba");
            }
        

            Console.ReadLine();
        }
    }
}
