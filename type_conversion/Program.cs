using System;

namespace type_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit

            byte a = 5;
            sbyte sb = 10;
            short c = 30;

            int d = a+sb+c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: "+h);

            float i = h;
            Console.WriteLine("i: " + i);

            string s = "test";
            char ch = 'k';
            object g = e+s+d;
            Console.WriteLine("g: " + g);


            // explicit

            int x = 3;
            byte y = (byte) x;
            Console.WriteLine("y: "+y);

            int z = 100;
            byte t = (byte) z;
            Console.WriteLine("t: "+t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            // toString
            int xx = 4;
            string yy = xx.ToString();
            Console.WriteLine("yy: "+ yy);

            yy = 12.3f.ToString();
            Console.WriteLine("yy: "+yy);

            // System.Convert

            string s1 ="10", s2="20";
            int sayı1, sayı2;
            int toplam;

            sayı1 = Convert.ToInt32(s1);
            sayı2 = Convert.ToInt32(s2);
            toplam = sayı1 + sayı2;
            Console.WriteLine("t: " + toplam);



        }
    }
}
