using System;
using System.Collections;
using System.Collections.Generic;

/* 
    Klavyeden girilen 20 adet pozitif sayının asal ve 
    asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
    -Negatif ve numeric olmayan girişleri engelleyin.
    -Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
    -Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

*/


namespace collections_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList prime = new ArrayList();
            ArrayList notPrime = new ArrayList();
            int count = 0;
            string input;
            int number;
            while(count < 20){
                Console.WriteLine((count+1).ToString()+ "."+" sayı: ");
                input = Console.ReadLine();
                if(Int32.TryParse(input, out number)){
                    if(number < 0)
                        Console.WriteLine("Pozitif sayı girin!");
                    else{
                        count++;
                        if(isPrime(number))
                            prime.Add(number);
                        else
                            notPrime.Add(number);
                    }
                }
                else
                    Console.WriteLine("Hatalı giriş!");
            }

            prime.Sort();
            prime.Reverse();
            Console.WriteLine("Prime numbers: ");
            foreach(int item in prime)
                Console.WriteLine(item);
            
            notPrime.Sort();
            notPrime.Reverse();
            Console.WriteLine("Not Prime numbers: ");
            foreach(int item in notPrime)
                Console.WriteLine(item);

            int sum = 0;
            foreach (int item in prime)
                sum += item;
            Console.WriteLine("Prime numbers size: " + prime.Count +" Mean: "+ sum/prime.Count);

            sum = 0;
            foreach (int item in notPrime)
                sum += item;
            Console.WriteLine("Prime numbers size: " + notPrime.Count +" Mean: "+ sum/notPrime.Count);

            



        }

        public static bool isPrime(int n){
            int m = n/2;
            bool flag = true;
            for(int i=2; i<m+1; i++){
                if(n % i == 0){
                    flag = false;
                    break;
                }
            }
            return flag;

        }
    }
}
