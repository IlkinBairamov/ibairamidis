using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("input howmuch Manat");
            double numb = double.Parse(Console.ReadLine());
            Console.WriteLine("input 1(dollar) or 2(Tl) or 3(streling)");
            int numb1 = int.Parse(Console.ReadLine());
            Currency convert = (Currency)numb1;
            Console.WriteLine("Answer");
            Valyuta(convert, numb);

        }
        static void Valyuta(Currency convert, double numb)
        {
            switch (convert)
            {                
                case Currency.dollar:
                    numb = numb * 1.7;
                    Console.WriteLine(numb);
                    break;
                case Currency.Tl:
                    numb = numb / 5;
                    Console.WriteLine(numb);
                    break;
                case Currency.sterling:
                    numb = numb * 0.43;
                    Console.WriteLine(numb);
                    break;
                default:
                    break;
            }
        }   
    
    }
    enum Currency
    {
        
        dollar=1,
        Tl,
        sterling

    }
}
