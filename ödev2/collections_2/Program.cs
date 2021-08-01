using System;
using System.Collections;
using System.Collections.Generic;


/*
    Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
    her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve 
    ortalama toplamlarını console'a yazdıran programı yazınız. 
    (Array sınıfını kullanarak yazınız.)
*/


namespace collections_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int[] max = new int[3];
            int[] min = new int[3];
            int count = 0;
            string input;
            int number;
            while(count < 20){
                Console.WriteLine((count+1).ToString()+ "."+" sayı: ");
                input = Console.ReadLine();
                if(Int32.TryParse(input, out number)){
                    arr[count] = number;
                    count++;
                }
                else
                    Console.WriteLine("Hatalı giriş!");
            }
            Array.Sort(arr);
            min[0] = arr[0];
            min[1] = arr[1];
            min[2] = arr[2];

            max[0] = arr[arr.Length -1];
            max[1] = arr[arr.Length -2];
            max[2] = arr[arr.Length -3];

            for(int i=0; i<3; i++)
                Console.WriteLine("Min: " + min[i] + "  Max: " + max[i]);
            double minOrt = (min[0]+min[1]+min[2])/3;
            double maxOrt = (max[0]+max[1]+max[2])/3;
            Console.WriteLine("Min arr ort: " + minOrt);
            Console.WriteLine("Max arr ort: " + maxOrt);
            Console.WriteLine("Ort: " + (minOrt+maxOrt)/2);

        }
    }
}
