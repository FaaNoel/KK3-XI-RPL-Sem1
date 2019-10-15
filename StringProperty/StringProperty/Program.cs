using System;

namespace StringProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            /*String nama = "Satela";
            // Length : adalah StringProperty yang digunakan untuk menghitung banyaknya karakter string.
            Console.WriteLine(nama.Length);

            //IndexOf adl property Yang digunakan untuk mencari char dalam baris string (membaca dari depan)
            Console.WriteLine(nama.IndexOf('a'));

            //LastIndexof adalah property yang digunakan untuk mencari char dalam baris string (membaca dari belakang)
            Console.WriteLine(nama.LastIndexOf('a'));

            //Insert adalah property yang digunakan untuk menyisipkan huruf atau kalimat di dalam barisan string
            //Format (namavariabel.insert(index ke-,"0"));
            Console.WriteLine(nama.Insert(4, "l"));

            //Replace adalah property yang digunakan untuk mengganti huruf dalam baris string
            // Format : Replace('huruf lama' , 'hutuf baru' );
            Console.WriteLine(nama.Replace('t', 'v'));

            // Remove : adalah property yang digunakan untuk menghapus huruf dari dalam baris string
            // Format :(namavar.Remove(index ke- berapa misal 0, sampai ke berapa misal 5));
            Console.WriteLine(nama.Remove(0, 3));

            //Substring : adalah property yang digunakan untuk melakukan pemnyalinan karakter di dalam baris string/
            // Format : (namavar.Substring(dari mana, sampai mana));
            Console.WriteLine(nama.Substring(0, 6));

            //Concatenate : adalah property yang digunakan untuk melakukan penggabungan 2 atau lebih string data1 dengan data2
            // string.Concat(data[1] +data{2[2] .................+ nama variabel n
            string e = "Hello";
            string p = "World!"; 
            Console.WriteLine(string.Concat(e+p));

            // Join :  adalah property yang berfungsi merekatkan beberapa string
            Console.WriteLine(string.Join(" ", e , p ));
*/
            //------------------------------------------------------------bab2-----------------------------------------------------
            //Array menggunakan String Property
            //1
            
            string[] anu = new string[] { "gitu", "terussan" };
            Console.WriteLine(anu[1].Length);

            //2
            Console.WriteLine(anu[1].IndexOf('a'));

            //3
            Console.WriteLine(anu[0].LastIndexOf('u'));

            //4 
            Console.WriteLine(anu[1].Insert(4, "ea"));

            //5
            Console.WriteLine(anu[1].Replace('s', 'S'));

            //6
            Console.WriteLine(anu[1].Remove(5));

            //7
            Console.WriteLine(anu[1].Substring(0, 5));

            //8
            string aa = "ANU";
            string bb = "Una";
            Console.WriteLine(string.Concat(aa + bb));

            //9
            Console.WriteLine(string.Join("&", aa, bb));
        
            

            Console.ReadLine();
        }
    }
}
