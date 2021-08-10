using System;

namespace Kalıtım_inheritance_stj
{
    using System;
    class Ev
    {
        public string sahip;
        public Ev()
        {
            Console.Write("Ev Bilgileri  ");
        }
        public void EvSahibiniYaz(string sahip)
        {
            Console.WriteLine("Ev ' in sahibi :  " + sahip);
        }
    }
    class ApartmanKatı : Ev
    {
        string apartmanYöneticisi;
        ApartmanKatı()
        {
            Console.WriteLine("Apartman Bilgileri");
        }
        void AptYöneticisiYaz(string s)
        {
            Console.WriteLine("Apartman Yöneticisi : " + s);
        }

        class Uygulama
        {
            public static void Main()
            {
                ApartmanKatı apt = new ApartmanKatı();

                Console.Write("Ev sahibi kim :");
                apt.sahip = Console.ReadLine();
                apt.EvSahibiniYaz(apt.sahip);

                Console.Write("Apartman Yöneticisi kim :");
                apt.apartmanYöneticisi = Console.ReadLine();
                apt.AptYöneticisiYaz(apt.apartmanYöneticisi);

            }
        }
    }


}
