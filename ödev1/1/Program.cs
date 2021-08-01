using System;

/*  
    Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
    Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
    Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. 
*/


namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif bir sayı girin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for(int i=0; i<n; i++){
                Console.WriteLine("Sayı girin: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i<arr.Length; i++){
                if(arr[i] % 2 == 0)
                    Console.WriteLine(arr[i]);
            }

            
        }
    }
}
