using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mod5_103022300066;

namespace mod5_103022300066
{
    class pemrosesData
    {
        public void DapatkanNilaiTerbesar<T>(T nilai1, T nilai2, T nilai3)
        {
            dynamic data1 = (dynamic)nilai1;
            dynamic data2 = (dynamic)nilai2;
            dynamic data3 = (dynamic)nilai3;

            if (data1 > data2 && data1 > data3)
            {
                Console.WriteLine("Nilai terbesar adalah " + data1);
            }
            else if (data2 > data1 && data2 > data3)
            {
                Console.WriteLine("Nilai terbesar adalah " + data2);
            }
            else
            {
                Console.WriteLine("Nilai terbesar adalah " + data3);
            }
        }
    }
}
