using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KopsterCompanyHR.HR
{
    internal class Manager : Employee
    {
        public Manager(string firstName, string lastName, string email, DateTime birthDay, double hourlyRate) : base(firstName, lastName, email, birthDay, hourlyRate)
        {
        }

        public void attendManagerMeeting()
        {
            NumberOfHoursWorked += 10;
            Console.WriteLine($"Manager {FirstName} {LastName} is attending meeting.");
        }

        public override void GiveBonus()
        {
            if (NumberOfHoursWorked > 10)
            {
                Console.WriteLine($"{FirstName} Received double Bonus");
            }
            else
            {
                Console.WriteLine($"{FirstName} got manager's bonus");
            }
        }
    }

}
