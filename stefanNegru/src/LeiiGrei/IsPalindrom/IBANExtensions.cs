using System;
using System.Collections.Generic;
using System.Text;
using LeiiGrei;

namespace IsPalindrom
{
    public static class IBANExtensions
    {
        public static bool IsPalindrom(this IBAN iban)
        {
            for (int i = 0; i < iban.AccountNumber.Length / 2; i++)
                if (iban.AccountNumber[i] != iban.AccountNumber[iban.AccountNumber.Length - i - 1])
                    return false;
            return true;
        }
    }
}
