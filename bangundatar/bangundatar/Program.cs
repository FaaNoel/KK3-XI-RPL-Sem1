using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bangundatar
{
    class Program
    {
        static void Main(string[] args)
        {
            persegi persegi1 = new persegi();
            persegipanjang persegipanjang1 = new persegipanjang();
            segitiga segitiga1 = new segitiga();
            jajargenjang jajargenjang1 = new jajargenjang();
            lingkaran lingkaran1 = new lingkaran();
            trapesium trapesium1 = new trapesium();
            belah_ketupat belahketupat1 = new belah_ketupat();

            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Persegi Panjang");
            Console.WriteLine("3. Segitiga");
            Console.WriteLine("4. Lingkaran");
            Console.WriteLine("5. jajar Genjang");
            Console.WriteLine("6. Trapesium");
            Console.WriteLine("7. Belah Ketupat");
            Console.WriteLine("-----------------");
            Console.WriteLine("-----------------");
            Console.Write("\nMasukan nomor yang ingin anda pilih : ");
            int nmr = int.Parse(Console.ReadLine());

            switch (nmr)
            {
                case 1:
                    persegi1.setsisipersegi();
                    persegi1.setluaspersegi();
                    persegi1.setkeliling();
                    break;

                case 2:
                    persegipanjang1.setpanjangpersegipanjang();
                    persegipanjang1.setlebarpersegipanjang();
                    persegipanjang1.setluaspersegipanjang();
                    persegipanjang1.setkelilingpersegipanjang();
                    break;

                case 3:
                    segitiga1.setalassegitiga();
                    segitiga1.settinggisegitiga();
                    segitiga1.setsisimiringsegitiga();
                    segitiga1.setluassegitiga();
                    segitiga1.setkelilingsegitiga();
                    break;

                case 4:
                    lingkaran1.setjarijarilingkaran();
                    lingkaran1.setluaslingkaran();
                    lingkaran1.setkelilinglingkaran();
                    break;

                case 5:
                    jajargenjang1.setalasjajargenjang();
                    jajargenjang1.setsisimiringjajargenjang();
                    jajargenjang1.settinggijajargenjang();
                    jajargenjang1.setluasjajargenjang();
                    jajargenjang1.setkelilingjajargenjang();
                    break;

                case 6:
                    trapesium1.setalastrapesium();
                    trapesium1.setalasatastrapesium();
                    trapesium1.setsisimiringtrapesium();
                    trapesium1.settinggitrapesium();
                    trapesium1.setluastrapesim();
                    trapesium1.setkelilingtrapesium();
                    break;

                case 7:
                    belahketupat1.setd1belahketupat();
                    belahketupat1.setd2belahketupat();
                    belahketupat1.setluasbelahketupat();
                    belahketupat1.setluasbelahketupat();
                    belahketupat1.setkelilingbelahketupat();
                    break;

                default:
                    Console.WriteLine("Masukan anda salah");
                    break;

            }
            Console.ReadLine();
        }
    }
}
