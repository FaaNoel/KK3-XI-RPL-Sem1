using System;
using System.Collections.Generic;
using System.Text;

namespace RumahTangga
{
    interface perusahaanrokok // just declarasi 
    {
        void sertification();
        void license();
        string experienceyear();
        string gaji();

    }
    // perbedaan abstract dan non, 
    // non ada body dan virtual override
    // abstract tidak ada body abstract override
    // interface harus mewariskan ke anaknya, semua di anggap abstract
}
