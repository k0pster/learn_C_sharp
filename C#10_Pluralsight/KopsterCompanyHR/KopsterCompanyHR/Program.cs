using KopsterCompanyHR.HR;


/*IEmployee jacula = new Employee("Jacek", "Zawada", "jacula@slepnacodswiatel@jojo.pl", new DateTime(1991, 03, 22), 32);
jacula.DisplayEmployeeDetails();
IEmployee dario = new Manager("Dariusz", "Kowalski", "dario@slepnacodswiatel@jojo.pl", new DateTime(1992, 04, 01), 30);
dario.DisplayEmployeeDetails();
IEmployee katerina = new Accountant("Katarzyna", "Kowalski", "kacha@slepnacodswiatel@jojo.pl", new DateTime(1993, 01, 02), 34);
katerina.DisplayEmployeeDetails();
IEmployee marecki = new Sales("Marek", "Grzmot", "maras@slepnacodswiatel@jojo.pl", new DateTime(1985, 05, 10), 42);
dario.DisplayEmployeeDetails();
IEmployee dzidek = new Employee("Janusz", "Nowak", "nowinho@slepnacodswiatel@jojo.pl", new DateTime(1996, 10, 05), 28, "Poznań", "12345", "Górska", "Poland");
dzidek.DisplayEmployeeDetails();*/

/*jacula.PerformWork(25);
dario.PerformWork(25);

double jaculaReceivedWage = jacula.ReceiveWage(true);
Console.WriteLine($"Wage paid : {jaculaReceivedWage}");

double darioReceivedWage = dario.ReceiveWage(true);
Console.WriteLine($"Wage paid : {darioReceivedWage}");

List<Employee> employees = new List<Employee>();
for (int i = 0; i < 10; i++)
{
    Employee randomEmployee = new Employee(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), new DateTime(1991, 03, 22), 30, EmployeeType.HR);
    employees.Add(randomEmployee);
    randomEmployee.displayEmployeeDetails();
}*/

//Możliwość pobierania ID pracownika dzieki liście(array) z wykorzystaniem podania długości przez użytkownika

/*Console.WriteLine("How many employees IDs will you want to register?");
int length = int.Parse(Console.ReadLine());
int[] employeesIds = new int[length];

for (int i = 0; i < length; i++)
{
    Console.WriteLine("Enter the employee ID: ");
    int id = int.Parse(Console.ReadLine());
    employeesIds[i] = id;
}

for (int i = 0; i < employeesIds.length; i++)
{
    Console.WriteLine($"Employee {i + 1} ID: {employeesIds[i]}");
}
*/
//dodać pracowników jako obiekty listy i następnie wygenerować raport płac

/*Employee[] employees = new Employee[5];

employees[0] = jacula;
employees[1] = dario;
employees[2] = katerina;
employees[3] = marecki;
employees[4] = dzidek;*/

/*List<Employee> employees = new List<Employee>();
employees.Add(jacula);
employees.Add(katerina);
employees.Add(dzidek);
employees.Add(marecki);
employees.Add(dario);


foreach (Employee employee in employees)
{
    employee.displayEmployeeDetails();
    var numbersOfHoursWorked = new Random().Next(50);
    employee.PerformWork(numbersOfHoursWorked);
    employee.ReceiveWage();
}*/

/*Console.WriteLine(marecki.FirstName);
string marName = marecki.FirstName = "dzik";
Console.WriteLine(marName);
Console.WriteLine(marecki.FirstName);
Console.WriteLine($"Address:\n{dzidek.Address.Country}\n{dzidek.Address.Street}\n{dzidek.Address.ZipCode}\n{dzidek.Address.City}");
dario.GiveBonus();
Console.ReadLine();*/

/*employess.Add(dario);
employess.Add(jacula);
employess.Add(marecki);
employess.Add(dzidek);
employess.Add(katerina);

foreach (Employee employee in employess)
{
    employee.DisplayEmployeeDetails();
    employee.GiveBonus();
}*/

//MAIN

List<Employee> employees = new List<Employee>();

string userSelection;

Console.WriteLine("..............\n");
Console.WriteLine("k0pster App");
Console.WriteLine("..............\n");

Utilities.CheckForExistingEmployee();

do
{
    Console.ForegroundColor= ConsoleColor.Cyan;
    Console.WriteLine($"Loaded {employees.Count} employee(s)!\n\n");
    Console.WriteLine("*************");
    Console.WriteLine("Select an action:");
    Console.WriteLine("1.Register Employees");
    Console.WriteLine("2.View all Employees");
    Console.WriteLine("3.Save Data");
    Console.WriteLine("4.Load Data");
    Console.WriteLine("5.Display Specific Employee");
    Console.WriteLine("9.Exit");
    Console.WriteLine("\nYour Selection:  ");
    Console.ResetColor();
    userSelection = Console.ReadLine(); 

    switch (userSelection)
    {
        case "1":
            Utilities.RegisterEmployee(employees);
            break;
        case "2":
            Utilities.ViewALlEmployees(employees);
            break;
        case "3":
            Utilities.SaveEmployees(employees);
            break;
       case "4":
            Utilities.LoadEmployees(employees);
            break;
        case "5":
            Utilities.ViewEmplyeeById(employees);
            break;
        case "9":
            break;
        default:
            Console.WriteLine("Invalid Selection. Please try again.");
            break;
    }
    
} while (userSelection != "9");
Console.WriteLine("Thanks for using app");
