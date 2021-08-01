using System;

/*
    Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
    Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
    Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
*/

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayı: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n < 1){
                Console.WriteLine("Sayı pozitif olmalı!");
                Console.Write("Press any key to close the console app...");
                Console.ReadKey();
            }
            Console.WriteLine("İkinci sayı: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            for(int i=0; i<n; i++){
                Console.WriteLine("Sayı girin: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i<arr.Length; i++){
                if(arr[i] % m == 0)
                    Console.WriteLine(arr[i]);
            }
            
        }
    }
}
