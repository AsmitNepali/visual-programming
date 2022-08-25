using System;

namespace ControlStatement
{
    class Program
    {
        static void Main(String[] args)
        {
            //Program for if-else
            int roll = 4;

            if (roll == 4)
            {
                Console.WriteLine("Name: Petter Parker \n Roll.No: 4 \n Address: New Wrok");
            }
            else
            {
                Console.WriteLine("Absent");
            }




            // Program for if-else ladder

            string status = "complete";

            if (status == "pending")
            {
                Console.WriteLine("Your Order Status Is Pending");
            }
            else if (status == "shipped")
            {
                Console.WriteLine("Your Order Has Beeb Shipped");
            }

            else if (status == "complete")
            {
                Console.WriteLine("Your Order Has Beed Delivered Successfully");
            }
            else
            {
                Console.WriteLine("Order Not Placed");
            }


            //Program for if-else nested
            // Find the largest number from given number

            Console.WriteLine("Enter First Number:");
            string num1String = Console.ReadLine();
            int num1 = Convert.ToInt32(num1String);

            Console.WriteLine("Enter Second Number");
            string num2String = Console.ReadLine();
            int num2 = Convert.ToInt32(num2String);

            Console.WriteLine("Enter Third Number");
            string num3String = Console.ReadLine();
            int num3 = Convert.ToInt32(num3String);

            if(num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine($"{num1} is largest");
                }
                else
                {
                    Console.WriteLine($"{num3} is largest");
                }
            }
            else
            {
                if(num2 > num3)
                {
                    Console.WriteLine($"{num2} is largest");
                }
                else
                {
                    Console.WriteLine($"{num3} is largest");
                }
            }

        }
    }
}
