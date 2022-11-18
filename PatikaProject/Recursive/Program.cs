
using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fibonacci kaca kadar gitsin: \n");

        int num = Convert.ToInt32(Console.ReadLine());
        fibonacci(1,1,1,num);
    }

    static int fibonacci(int a, int b, int temp, int last)
    {

        temp = a;
        if (a == 1)
        {
            Console.WriteLine(1);
        }

        if (a > last)
        {
            return 0;
        }

        Console.WriteLine(a);

        a += b;
        b = temp;
        temp = a;

        return (fibonacci(a, b, temp, last));
    }
}