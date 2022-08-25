using System;

namespace SwitchCase
{
    class Switchcase
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Your Day:");

            string day = Console.ReadLine();


            int day_num = Convert.ToInt32(day);

            switch (day_num)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;

                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;

                case 4:
                    Console.WriteLine("Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Thursday");
                    break;

                case 6:
                    Console.WriteLine("Friday");
                    break;

                case 7:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Invalid days");
                    break;
            }

        }
    }
}