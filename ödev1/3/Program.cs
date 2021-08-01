using System;

/*
    Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
    Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
    Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
*/


namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n < 1){
                Console.WriteLine("Sayı pozitif olmalı!");
                Console.Write("Press any key to close the console app...");
                Console.ReadKey();
            }
            string[] inputs = new string[n];
            for(int i=0; i<n; i++){
                Console.WriteLine("Kelime girin: ");
                inputs[i] = Console.ReadLine();
            }

            for(int i=n-1; i>-1; i--){
                Console.WriteLine(inputs[i]);
            }
        }
    }
}
