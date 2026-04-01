using System;
namespace Modul5_103022300012
{
    

class Program
{
        class PemrosesData
        {
            public void DapatkanNilaiTerbesar<T>(T a, T b, T c)
            {
                dynamic temp1 = a;
                dynamic temp2 = b;
                dynamic temp3 = c;

                if (temp1 > temp2 && temp1 > temp3)
                {
                    Console.WriteLine($"Nilai terbesar adalah: {a}");
                }
                else if (temp2 > temp1 && temp2 > temp3)
                {
                    Console.WriteLine($"Nilai terbesar adalah: {b}");
                }
                else
                {
                    Console.WriteLine($"Nilai terbesar adalah: {c}");
                }
            }
        }

        private static void Main(string[] args)
        {
            PemrosesData pemrosesData = new PemrosesData();
            pemrosesData.DapatkanNilaiTerbesar(10.0, 30.0, 22.0);
        }
    }
}