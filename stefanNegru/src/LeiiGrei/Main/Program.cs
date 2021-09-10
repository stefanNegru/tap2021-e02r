using System;
using LeiiGrei;
using IsPalindrom;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IBAN ibanPalindrom = new IBAN("RO38PORL1234567887654321");
            Console.WriteLine(ibanPalindrom.IsPalindrom());

            IBAN ibanNotPalindrom = new IBAN("RO38PORL1111111100000000");
            Console.WriteLine(ibanNotPalindrom.IsPalindrom());
        }
    }
}
