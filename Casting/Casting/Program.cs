using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 12;
            short y = 10;
            int z = 8;
            long t = 5;
            float k = 13;
            // k=t;  (doğru) küçüğü büyüğe atıyoruz.
            // x=y ;(yanlış)
            // y=x ;(doğru)
            // string f;  Hata alırız çünkü değişken tipleri farklıdır Explicit Casting olarak yapmamız gerek 

            double i = 24;
            int h;
            h = (int)i; //Explicit 

            double f = 24;
            int g;
            g = Convert.ToInt32(f);//Convert
            string g = f.ToString(); // ToString her değişken türüne çevriliri.
        }
    }
}
