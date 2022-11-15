
using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1 ile 10 arasinda bir sayi giriniz.");
        int num =Convert.ToInt32(Console.ReadLine());
        if (num <= 5)
        {
            Console.WriteLine("Sayi besten kücük");
        }
        else
        {
            Console.WriteLine("Sayi besten büyük");

        }

    }
}