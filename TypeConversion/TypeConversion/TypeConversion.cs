using System;

namespace TypeConversion
{
    class TypeConversion
    {
        static void Main(String[] args)
        {
            //char->int->long->float->double #Implicit
            //double->float->long->int->char #Explicit


            int myInt = 99;
            double myDouble = myInt; //Automatically convert into double


            double yourDouble = 99.99;
            int yourInt = (int) yourDouble;

            Console.WriteLine(myDouble);
            Console.WriteLine(yourInt);

            // Conversion method

            //Console.WriteLine(Convert.ToString(yourInt));
            //Console.WriteLine(myDouble.ToString());

        }
    }
}