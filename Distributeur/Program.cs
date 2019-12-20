using System;

namespace Distributeur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Distributeur.ServirBoisson(Boissons.Cafe, 2, 15));


            decimal prix = 3.5m;

            Console.WriteLine(prix.ToString("C2"));
        }
    }
}
