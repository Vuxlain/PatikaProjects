
using System;


class Program
{
    static void Main(string[] args)
    {
        int a = 42;
        int b = 20;

        Console.WriteLine(a - b);
        change(a, b);
        Console.WriteLine(a - b);
    }


    static void change(int a,int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}