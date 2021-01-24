using System;

namespace _3_Gun_Odevler
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result= Add2(12, 23);
            Console.WriteLine(result);
            var result1=Delete("halil");

            int number1 = 20;
            int number2 = 30;
            var result2 = Topla(ref number1, number2);
            
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Ekledi");
        }

        static int Add2(int sayi1, int sayi2)
        {
            var result = sayi1 + sayi2;
            return result;
        }

        static string Delete(string ad,string soyad="beydüz")
        {
            
            var result1 = ad + soyad;
            return result1;
        }

        static int Topla(ref int number1,int number2)
        {
            number1 = 40;
            return number1 + number2;
        }

    }
}
