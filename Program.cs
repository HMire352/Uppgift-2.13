using System;
namespace Uppgift_2._13
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Write("lön för Abel?");
            int Abel = int.Parse(Console.ReadLine());
            Console.WriteLine("lön för Nasteho?");
            int Nasteho = int.Parse(Console.ReadLine()); 
            Console.WriteLine("lön för Josef?");
            int Josef = int.Parse(Console.ReadLine());

            Console.WriteLine(" Abel" + Abel + " kr" + " Nasteho" + Nasteho + " Josef" + Josef + " kr");

            Console.WriteLine("medelönen för ");

            Console.WriteLine(( Abel + Nasteho + Josef) /3 );
        }
    }
}