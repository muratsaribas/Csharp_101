using System;

namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Console.WriteLine("Bir sayı giriniz: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayı: " + num1);

            }
            catch(Exception ex){
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally{
                Console.WriteLine("İşlem tamam");
                
            }

            try{
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-99999999999999");
            }
            catch(ArgumentNullException ex){
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            catch(FormatException ex){
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            catch(OverflowException ex){
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally{
                Console.WriteLine("İşlem tamam");
            }
        }
    }
}
