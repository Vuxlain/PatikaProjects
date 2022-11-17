
using System;


class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 5,9,7,15,4,2,9,6,44,1,3,64,51};
        foreach (var i in arr)
        {
            Console.Write(i+"-");
        }
        
        Console.WriteLine();
        Console.WriteLine("**********************");
        Array.Sort(arr);
        Array.Reverse(arr);
        foreach (var i in arr)
        {
            Console.Write(i+"-");
        }
        Console.WriteLine();
        Console.WriteLine("5'in indexi: "+Array.IndexOf(arr,5));
    }
}