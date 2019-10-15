using System;

namespace ExceptionsHandling
{
    class Program
    {
        // jika format inputtan tidak sesuai tipe data yang ditentukan,misalnya harusnya input angka, malah input huruf
        /*try
            {
                Console.WriteLine("Masukkan Umur Kamu :");
                int umur = int.Parse(Console.ReadLine());
                Console.WriteLine("Umur Kamu adalah :" + umur);
            }
            catch(FormatException)
            {
                Console.WriteLine("Inputtan salah, umur kan harusnya angka, lu malah huruf gimana sih ?!");
            }*/
        //------------------------------------------------------------spasi----------------------------------------------------------
        // jika menginputkan pembagian dengan angka 0
        /*
         * try{
            Console.WriteLine("Masukkan angka 1 :");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan angka 1 :");
            int y = int.Parse(Console.ReadLine());
            int z = x / y;
            Console.WriteLine("Hasil nya adalah : " + z);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Gabisa di bagi nol, masukkan angka selain 0");
        }*/
        //-----------------------------------------------------------spasi-----------------------------------------------------------
        // Membuat 2 Catch itu bisa gan, ini contohnyaa   
        /*try{
         * Console.WriteLine("Masukkan angka 1 :");
              int x = int.Parse(Console.ReadLine());
              Console.WriteLine("Masukkan angka 1 :");
              int y = int.Parse(Console.ReadLine());
              int z = x / y;
              Console.WriteLine("Hasil nya adalah : " + z);
              }
               catch (FormatException)
                {
                      Console.WriteLine("Inputtan salah, umur kan harusnya angka, lu malah huruf gimana sih ?!");
                 }
                 catch (DivideByZeroException)
                {
                     Console.WriteLine("Gabisa di bagi nol, masukkan angka selain 0");
                 }*/
            //----------------------------------------------------spasi----------------------------------------------------------------
            //
            //Jika inputtan array lebih dari yang di tentukan
            /*try
            {
                string[] buah = new string[3] { "Apple", "Grape", "Pineapple" };
                Console.WriteLine(buah[0]);
                Console.WriteLine(buah[1]);
                Console.WriteLine(buah[-7]);
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Inputtan diluar dari batas Array");
            }*/

        static void Main(string[] args) 
        {
            //ARrray 
            // adalah Keranjang
            //tipedata [] namavariabel = new tipedata[] {'data1', 'data 2', etc}
            //

            try
            {
                Console.WriteLine("Masukkan Umur Kamu :");
                int umur = int.Parse(Console.ReadLine());
                Console.WriteLine("Umur Kamu adalah :" + umur);
            }
            catch (FormatException)
            {
                Console.WriteLine("Inputtan salah, umur kan harusnya angka, lu malah huruf gimana sih ?!");
            }
            finally
            {
                Console.WriteLine("Sabar ya, ngoding itu harus sabar, kamu harus gigih dan tidak pantang menyerah :)");
            }








            Console.ReadLine();
            
        }
    }
}
