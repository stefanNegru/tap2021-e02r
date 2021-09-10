using System;
using System.Collections.Generic;
using System.Text;

namespace LeiiGrei
{
    public class IBAN
    {
        public string iban { get; set; }
        public string AccountNumber { get; set; }
        public IBAN(string iban)
        {
            this.iban = iban;
            this.AccountNumber = iban.Substring(8);
        }
    }
}
