using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KopsterCompanyHR.HR
{
    internal class Employee: IEmployee
    {
        private string firstName; //zasada enklapsulacji każe nam chronić możliwość zmiany wartości zmiennych w klasie.
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double hourlyRate;

        private DateTime birthDay;
        private const int minimalHoursWorkedUnit = 1;
        
        private static double taxRate = 0.15;
        private Address address;

        //Objected Oriented

        //Stosowanie enkapsulacji uniemożliwia zmianę wartości w obiekcie wprost z zewnątrz aplikacji.
        //Tworzenie w klasi metodę o tej samej nazwie w formacie Pascala z get-em do zwracania na zewnątrz
        //zadeklarowanej w środku programu zmiennej prywatnej, oraz set-em dającym możliwość zmiany jego 
        //wartości. Żeby móc dostać się do zmiennej z zewnątrz musimy wywołać exampleEmployee.FirstName, 
        //nie mamy już dostępu do prywatnej zmiennej firstName poprzez wywołanie/modyfikacje exampleEmployee.firstName

        //Inheritance = dziedziczenie poprzez używanie dostępu[public, private, protected] gdy chcemy dziedziczyć 
        //zmienne lub metody od klasy np. Employee [klasa bazowa] zmienną name do klasy public class Manager: Employee
        //[taki zapis pozwala określić rodzica od którego dziedziczyć będzie zmienne klasa Manager.]
        //public - dostęp nawet z zewnątrz, private - niedostępny z zewnątrz, tylko do użytku wewnątrz, 
        //protected - jest jak private na zewnątrz oraz jak public dla dziedziczącej klasy(w tym przypadku Manager.)
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public int NumberOfHoursWorked
        {
            get
            {
                return numberOfHoursWorked;
            }
            protected set //protected przy set-cie uniemożliwia zmiane wartości danej zmiennej z zewnątrz ale pozwala na to dziedziczącemu
            {
                numberOfHoursWorked = value;
            }
        }

        public double Wage
        {
            get
            {
                return wage;
            }
            private set //private przy set-cie uniemożliwia zmiane wartości danej zmiennej
            {
                wage = value;
            }
        }

        public double HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            set
            {
                if (hourlyRate < 0 )
                {
                    hourlyRate = 0;
                }
                else
                {
                    hourlyRate = value;
                }
            }
        }

        public DateTime BirthDay
        {
            get
            {
                return birthDay;
            }
            set
            {
                birthDay = value;
            }
        }

        /*public int MinimalHoursWorkedUnit
            {
            get
            {
                return minimalHoursWorkedUnit;
            }
            set
            {
                minimalHoursWorkedUnit = value
            }
            }*/

        public static double TaxRate
        {
            get
            {
                return taxRate;
            }
            set
            {
                taxRate = value;
            }
        }
        public Employee(string firstName, string lastName, string email, DateTime birthDay, double hourlyRate, string city, string zipCode, string street, string country)
        {
            FirstName= firstName;
            LastName= lastName;
            Email= email;
            BirthDay= birthDay;
            HourlyRate= hourlyRate;
            Address = new Address(street, city, zipCode, country);
        }

        public Employee(string firstName, string lastName, string email, DateTime birthDay) : this(firstName, lastName, email, birthDay, 0)
        {
        }
        public Employee(string firstName, string lastName, string email, DateTime birthDay, double hourlyrate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            HourlyRate = hourlyrate;
        }

        public Address Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public void PerformWork()
        {
            //snumberOfHoursWorked++;
            PerformWork(minimalHoursWorkedUnit);
            //Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)");
        }

        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{FirstName} {LastName} has worked for {numberOfHours} hour(s)");
        }

        public double ReceiveWage(bool resetHours = true)
        {
            double wageBeforeTaxes = NumberOfHoursWorked * HourlyRate;

            double taxAmount = wageBeforeTaxes * taxRate;
            wage = wageBeforeTaxes - taxAmount;


            Console.WriteLine($"{FirstName} {LastName} has earned {Wage} for {NumberOfHoursWorked} number of hour(s) of work");
            if (resetHours)
            {
                NumberOfHoursWorked = 0;
            }

            return Wage;
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($" {FirstName} received Bonus");
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst Name: \t{FirstName}\nLast Name: \t{LastName}\nBirtday: \t{BirthDay.ToShortDateString()}\n" +
                $"Email: {Email}\nHourlyRate: {HourlyRate}");

        }


    }
}
