using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangun_Ruang
{
    class kubus
    {
        private int sisikubus;
        private int volumekubus;
        private int luaspermukaan;

        public int getsisi()
        {
            return sisikubus;
        }
        public int setsisi()
        {
            Console.WriteLine("Masukan sisi kubus : ");
            int xsisi = int.Parse(Console.ReadLine());
            sisikubus += xsisi;
            return xsisi;
        }

        public int setvolumekubus()
        {
            volumekubus = sisikubus * sisikubus * sisikubus;
            Console.WriteLine("Volume Kubus : " + volumekubus);
            return volumekubus;
        }
        public int setluaspermukaan()
        {
            luaspermukaan = 6 * sisikubus;
            Console.WriteLine("Luas Permukaan Kubus : " + luaspermukaan);
            return luaspermukaan;

        }
    }
}
