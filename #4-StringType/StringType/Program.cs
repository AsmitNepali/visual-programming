using System;

namespace StringType
{
    class Progarm
    {
        static void Main(String[] args)
        {
            String str = "Hello\rWorld!";

            String myString = @"Hello\rWorld!";

            int num1 = 5;
            int num2 = 4;

            Console.WriteLine($"Sum: {num1 + num2 }");

            Console.WriteLine(str);
            Console.WriteLine(myString);
        }
    }
}