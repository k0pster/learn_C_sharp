using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KopsterCompanyHR.HR
{
    internal class Accountant : Employee
    {
        public Accountant(string firstName, string lastName, string email, DateTime birthDay, double hourlyRate) : base(firstName, lastName, email, birthDay, hourlyRate)
        {
        }
    }
}
