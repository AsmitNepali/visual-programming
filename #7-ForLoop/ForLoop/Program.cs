using System;

namespace ForLoop
{
    class ForLoop
    {
        static void Main(String[] args)
        {
            for(int i = 0; i <= 4; i ++)
            {
                for(int j = 0; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n\n\n\n\n");


            for(int i = 0; i <= 4; i++)
            {
                for(int j = 0; j <= 4; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
