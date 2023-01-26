using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace KopsterCompanyHR.Accounting
{
    internal class Accounting
    {
        public class Acount
        {
            private string accountNumber;
            
            public string AccountNumber
            {
                get{return accountNumber;}
                set 
                { 
                    accountNumber = value;
                }
            }
        }
    }
}
