using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hewan
{
    class cacing : chicken
    {
        public new void makan()
        {
            Console.WriteLine("nasi");
        }

        public int lari(int x)
        {
            Console.WriteLine("Wussshhhhhh");
            return x;
        }
    }
}
