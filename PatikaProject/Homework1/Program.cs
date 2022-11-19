
using System;
using System.Xml;


class Program
{
    static void Main(string[] args)
    {
        /**************** Soru 1 ****************
        Console.WriteLine("Bir Pozitif Tam Sayı Giriniz: ");
        int n=Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];        
        
        Console.WriteLine(n+" Tane Sayı Giriniz:  ");
        for(int i=0;i<arr.Length;i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());

        }
        int a = 1;
        foreach(int i in arr)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(a+". "+i);
                a++;
            }
        }*/

        /**************** Soru 2 ****************

        int n, m;
        Console.WriteLine("2 Pozitif Tam Sayı Giriniz: ");
        Console.WriteLine("1.");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("2.");
        m = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];


        Console.WriteLine(n + " Tane Sayı Giriniz:  ");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int a = 1;
        foreach (int i in arr)
        {
            if (i % m == 0)
            {
                Console.WriteLine(a + ". " + i);
                a++;
            }
        }*/

        /**************** Soru 3 ****************

        Console.WriteLine("Bir Pozitif Tam Sayı Giriniz: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr = new string[n];

        Console.WriteLine(n + " Tane Kelime Giriniz:  ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine((i+1)+". Kelime: ");
            arr[i] = Console.ReadLine();

        }
        Array.Reverse(arr);
        foreach (string a in arr)
        {
            Console.WriteLine(a);
        }*/

        /**************** Soru 4 ****************

        Console.WriteLine("Bir Cümle Giriniz: ");
        string sentc = Console.ReadLine();
        char n;
        int count = 0;
        int count2 = 0;
        for(int i=0;i<sentc.Length;i++)
        {
            n= sentc[i];
            if(n!=' ')
            {
                count++;
            }
            if(n==' ')
            {
                count2++;      
            }
        }

        Console.WriteLine("Cümledeki Kelime Sayısı: "+(count2+1));
        Console.WriteLine("Cümledeki Harf Sayısı: "+count);
        */

    }


}