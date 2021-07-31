using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte b = 5;     // 1 byte 0,255
            sbyte c = 5;    // 1 byte -128,127

            short s = 5;    // 2 byte
            ushort us = 5;  // 2 byte

            Int16 i16 = 2;  // 2 byte
            int i = 2;      // 4 byte
            Int32 i32 = 2;  // 4 byte
            Int64 i64 = 2;  // 8 byte

            uint ui = 2;    // 4 byte
            long l = 2;     // 8 byte
            ulong ul = 2;   // 8 byte

            float f = 5;    // 4 byte
            double d = 2;   // 8 byte
            decimal dd = 5; // 16 byte

            char ch = 'c';  // 2 byte
            string str = "test";
            
            bool b1 = true;

            DateTime dt = DateTime.Now; 

            object o1 = "ss";
            object o2 = 'c';
            object o3 = 4;
            object o4 = 4.2;

            string str1 = string.Empty;
            str1 = "test test";

            string str2 = str + " " + str1;

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            bool b2 = 10<2;


            string str11 = "22";
            int integer4 = 15;

            string str22 = str11 + integer4.ToString();

            integer1 = integer4 + Convert.ToInt32(str11);

            integer1 = integer4 + int.Parse(str11);

            string dt = DateTime.Now.ToString("dd.MM.yyyy");

            dt = DateTime.Now.ToString("dd/MM/yyyy");

            string hour = DateTime.Now.ToString("HH:mm");


        }
    }
}
