using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derinlikle Fibonacci toplamı uygulamasına hoşgeldiniz!!");
            int derinlik = 0;
            int a = 0, b = 1, c;
            Console.WriteLine("Derinlik için istediğiniz sayıyı giriniz:");
            derinlik = Convert.ToInt32(Console.ReadLine());

            int toplam = a + b; 

            
            if (derinlik == 1)
            {
                Console.WriteLine($"Fibonacci dizisinin ilk terimi: {a}");
                toplam = a; 
            }
            else if (derinlik == 2)
            {
                Console.WriteLine($"Fibonacci dizisinin ilk iki terimi: {a}, {b}");
            }
            else
            {
                Console.WriteLine($"Fibonacci dizisinin ilk iki terimi: {a}, {b}");
                
                for (int i = 2; i < derinlik; i++)
                {
                    c = a + b;  
                    Console.WriteLine(c);  
                    a = b; 
                    b = c;
                    toplam += c;  
                }
            }
            
                
            Console.WriteLine($"Fibonacci dizisinin toplamı: {toplam}");
        }
    }
}