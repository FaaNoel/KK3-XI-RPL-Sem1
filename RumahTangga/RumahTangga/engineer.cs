using System;
using System.Collections.Generic;
using System.Text;

namespace RumahTangga
{
    class engineer : perusahaanrokok
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
    }
}
