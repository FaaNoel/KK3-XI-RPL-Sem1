using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hewan
{
    class chicken
    {   //polymorphisme

        //overriding : metode untuk mewariskan method yang sama dengan isinya yang berbeda
        //virtual : permission/ izin dari induk bahwa memiliki method yang berbeda
        //hiding/shadowing : menyembunyikan method yang sama tp isinya berbeda
        //overloading : method nya sama tp argumen atau parameternya berbeda
        public void makan()
        {
            Console.WriteLine("Tahu");
        }

        public int lari (int x, int y, int z)
        {
            Console.WriteLine("Wuuuuussshhhhhh");
            return y;
        }
    }
}
