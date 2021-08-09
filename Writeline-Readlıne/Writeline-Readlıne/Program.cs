using System;

namespace Writeline_Readlıne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name :"); // WriteLine'da imleç direkt alt satıra geçer.
            string name = Console.ReadLine(); //string te ReadLine komutu kullan !
            Console.WriteLine("WELCOME "+name +" !!! \n");
            Console.WriteLine("---------------------------------------");
            Console.Write("Yasınız :");
            string age = Console.ReadLine();
            Console.WriteLine(age+" Yasındasın");
            Console.WriteLine("---------------------------------------");
            Console.Write("What is your name :"); // WriteLine'da imleç direkt alt satıra geçer.
            int acicode = Console.Read(); //int te Read komutu kullan !
            Console.WriteLine(acicode);
            Console.ReadKey();
        }
    }
}
