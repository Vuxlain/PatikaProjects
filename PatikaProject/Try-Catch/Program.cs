
using System;


class Program
{
    static void Main(string[] args)
    {
        try{
            Console.WriteLine("Bir sayi giriniz.");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiginiz sayi: " + num);
           
        }
        catch(Exception ex) {
            Console.WriteLine("Hata: "+ex.Message.ToString());
        }
        finally { 
            Console.WriteLine("İslem Tamamlandi."); 
        }
    }

}