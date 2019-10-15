using System;

namespace KalkulatorConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Kalkulator kalkulator1 = new Kalkulator(5, 8);
            try
            {
                kalkulator1.penjumlahan();
                kalkulator1.pembagian();
                kalkulator1.perkalian();
                kalkulator1.pengurangan();
            }
            catch (FormatException)
            {
                Console.WriteLine("Inputtan salah, umur kan harusnya angka, lu malah huruf gimana sih ?!");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Tidak bisa input 0 pada Pembagian");
            }
            finally
            {
                Console.WriteLine("Terimakasih sudah mencoba");
            }
            Console.ReadLine();
        }
    }
}
