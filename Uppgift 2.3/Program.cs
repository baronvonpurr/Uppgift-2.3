using System;

namespace InlemningsUppgift2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt har du kört i km?");
            Double Långkört = Double.Parse(Console.ReadLine());
            Console.WriteLine("Hur många dagar har dy hyrt?");
            Double Daghyrd = Double.Parse(Console.ReadLine());
            Console.WriteLine("Du betalar" + (300 + Långkört + Daghyrd * 500) + "kr");
            Console.ReadKey();
        }
    }
}