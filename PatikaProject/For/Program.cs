
using System;


class Program
{
    static void Main(string[] args)
    {
        int[] arr= new int[10];

        for (int i =0;i< arr.Length; i++)
        {
            if (i == 2)
                arr[i]=i*24;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}