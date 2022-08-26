using System;

namespace Varibles{

class Program
{
    static void Main(string[] args)
    {
        int myInt = 100;
        double myDouble = 99.99;
        float myFloat = 9;
        byte myByte = 255; // if you initialize the value of byte greate than 256 it will give you an error.

        string myString = "This is a string data type";
        char myChar = 'A';

        Boolean status;

        status = true;


        Console.WriteLine(myInt);
        Console.WriteLine(myFloat);
        Console.WriteLine(myByte);
        Console.WriteLine(status);
        Console.WriteLine(myString);
        Console.WriteLine(myChar);


    }
}
}
