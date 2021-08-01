using System;

/*
    Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
    Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
*/


namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle girin: ");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            int letCount = 0;
            foreach(string ss in words){
                letCount += ss.Length;
            }

            Console.WriteLine("Kelime sayısı: " + words.Length+ " Harf sayısı: " + letCount);
             
        }
    }
}
