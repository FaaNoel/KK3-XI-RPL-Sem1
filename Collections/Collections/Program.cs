using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array List
            //Kekurangan Array : Fixed Length, Imposible Insert or Remove
            // Sifat Array List : Dinamic

            ArrayList array = new ArrayList();
            Console.WriteLine(array.Capacity);
            //Capacity property yang digunakan untuk melihat memory yang digunakan oleh array list.

            array.Add(100);
            //Add adalah property yang digunakan untuk menambah item dalam array list secara dinamis.
            Console.WriteLine(array.Capacity);
            array.Add(200);
            Console.WriteLine(array.Capacity);
            array.Add(300);
            Console.WriteLine(array.Capacity);
            array.Add(400);
            Console.WriteLine(array.Capacity);
            array.Add(500);
            Console.WriteLine(array.Capacity);
            array.Add(600);
            Console.WriteLine(array.Capacity);
            array.Add(700);
            Console.WriteLine(array.Capacity);
            array.Add(800);
            Console.WriteLine(array.Capacity);

            

            array.Insert(1, 150);




            //Foreach adalah variabel untuk menampilkan hasil array list, yang perulangan yang khusus digunakan oleh array.   
            

            // REMOVE membuang isi
            array.Remove(100);

            
            // REMOVEAT membuang index
            array.RemoveAt(0);
            
            // REMOVERANGE membuang didalam range
            array.RemoveRange(0, 2);

            //CONTAINS Cara programmer untuk bertanya pada sistem untuk mencari value pada indeks array
            if (array.Contains(800))
            {
                Console.WriteLine("Data ditemukan pada indeks ke " + array.IndexOf(800));
                
            }
            else
            {
                Console.WriteLine("Maaf data yang anda cari tidak ditemukan");
            }


            foreach (int a in array)
            {
                Console.Write(a + " ");
            }

            Console.ReadLine();
            
        }
    }
}
