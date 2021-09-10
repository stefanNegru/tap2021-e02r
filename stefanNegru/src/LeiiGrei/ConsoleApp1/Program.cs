using System;
using LeiiGrei;
using IsPalindrom;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IBAN iban = new IBAN("RO38PORL2234567887654321");
            Console.WriteLine(iban.IsPalindrom());
        }
    }
}
