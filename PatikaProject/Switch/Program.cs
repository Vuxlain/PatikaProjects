
using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1 yada 0 sayilarından birini giriniz.");
        int num =Convert.ToInt32(Console.ReadLine());
        switch (num )
        {
            case 1:
                Console.WriteLine("Sayi: " + num);
                break;
            case 0:
                Console.WriteLine("Sayi: " + num);
                break;
            default:
                Console.WriteLine("Gecersiz Deger");
                break;
                
        }

    }
}