
using System;


class Program
{
    static void Main(string[] args)
    {
        int x = 2;
        int y = 1;

        y = y + 3;
        y += 3;  

        x = x * 3;
      

        bool isTrue = true;
        bool isFalse = false;

        if (isTrue && isFalse)
        {
            Console.WriteLine("is not working.");
        }

        if (isTrue || isFalse)
        {
            Console.WriteLine("working");
        }

        if (isTrue && !isFalse)
        {
            Console.WriteLine("working");
        }


        int num1 = 5;
        int num2 = 5;
        bool result = number1 != number2;
        Console.WriteLine(result);

        int a = 10;
        int b = 2;
        int result2 = a / b;
        Console.WriteLine(result2); 


        int c = a % 3;
        Console.WriteLine(c);




    }
}