
using System;


class Program
{
    static void Main(string[] args)
    {
        int timer = 1;
        while (timer <= 5)
        {
            Console.WriteLine(timer);
            timer++;
        }

        int[] arr = { 2, 4, 5, 1, 2, 4 };
        int sum= 0;

        foreach (int i in arr)
        {
            sum += i;
        }
    }
}