using System;

namespace PGCD
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Entrez le premier nombre :");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le second nombre :");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Le PGCD de {x} et de {y} = {PGCD(x, y)}");
        }

        static int PGCD(int p, int q)
        {
            while (p != q)
            {
                if (p > q)
                {
                    p = p - q;
                } else
                {
                    q = q - p;
                }
            }          
            return p;
        }
    }
}
