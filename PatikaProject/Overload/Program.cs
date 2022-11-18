
using System;


class Program
{
    static void Main(string[] args)
    {
        int a = 42;
        int b = 20;
        int c = 15;
        Console.WriteLine(sum(a, b));
        Console.WriteLine(sum(a, b,c));

    }


    static int sum(int a,int b)
    {
        return a + b;
    }

    static int sum(int a, int b,int c)
    {
        return a + b+cs;
    }
}