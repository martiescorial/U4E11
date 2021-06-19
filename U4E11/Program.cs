using System;

namespace U4E11
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;
            if (x > y)
            {
                Console.WriteLine("x es mayor que y");
            }else
            {
                if (y > x) 
                {
                    Console.WriteLine("y es mayor que x");
                }else
                    Console.WriteLine("x e y son iguales");
            }
        }
    }
}
