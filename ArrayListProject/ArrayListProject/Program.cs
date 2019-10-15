using System;
using System.Collections;

namespace ArrayListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();

            Console.WriteLine("Masukkan array :");
            arr.Add(Console.ReadLine());
            Console.WriteLine("Masukkan array :");
            arr.Add(Console.ReadLine());
            Console.WriteLine("Masukkan array :");
            arr.Add(Console.ReadLine());
            Console.WriteLine("Masukkan array :");
            arr.Add(Console.ReadLine());
            Console.WriteLine("Masukkan array :");
            arr.Add(Console.ReadLine());
            Console.WriteLine("Masukkan array :");
            arr.Add(Console.ReadLine());
            Console.WriteLine("Masukkan array :");
            arr.Add(Console.ReadLine());
            Console.WriteLine("Masukkan array :");
            arr.Add(Console.ReadLine());
            Console.WriteLine("Masukkan array :");
            arr.Add(Console.ReadLine());
            Console.WriteLine("Masukkan array :");
            arr.Add(Console.ReadLine());
            Console.WriteLine(arr.Capacity);

            foreach (string a in arr)
            {
                Console.Write(a + " ");
            }

            Console.ReadLine();

        }
    }
}
