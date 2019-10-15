using System;
using System.Collections.Generic;
using System.Text;

namespace RumahTangga
{
    class supervisor : perusahaanrokok //boleh menuliskan inheritance boleh tidak. KEUNGGULAN INTERFACE.
    {
        public void sertification()
        {
            Console.WriteLine("Sertifikat Kelulusan");
        }
        public void license()
        {
            Console.WriteLine("Lisensi Kelulusan");
        }
        public string experienceyear()
        {
            string x = "1 tahun";
            Console.WriteLine("Jumlah pengalaman kerja :");
            return x;

        }
        public string gaji()
        {
            string xgaji = "5000000";
            Console.WriteLine("Jumlah Gaji :");
            return xgaji;
        }
        // perbedaan void dan non void
        // void terdapat using void dan tidak memiliki return
        // non void memakai type data dan terdpat return, dan return terdapat dataaaa diatasnya.
    }
}
