using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KopsterCompanyHR.HR
{
    internal class Utilities
    {
        private static string directory = @"C:\Users\kopec\Desktop\Kurs IT\C#\C#10 PS PATH\KopsterCompanyHR\";
        private static string fileName = "employees.txt";

        internal static void RegisterEmployee(List<Employee> employees)
        {
            Console.WriteLine("Creating an employee");
            Console.WriteLine("What type of an employee you want to create?");
            Console.WriteLine("1. Employee\n2. Manager\n3. Sales\n4. Accountant\n 5. Developer\n 6. JuniorDeveloper");
            Console.WriteLine("Your Selection:  ");
            string employeeType = Console.ReadLine();

            if (employeeType != "1" && employeeType != "2" && employeeType != "3" && employeeType != "4" && employeeType != "5" && employeeType != "6")
            {
                Console.WriteLine("Wrong selection!");
                return;
            }
            Console.WriteLine("Provide name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Provide surname: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Provide email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter birth day:");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Provide hourly rate amount: ");
            string hourlyRate = Console.ReadLine();
            double rate = double.Parse(hourlyRate);

            Employee employee = null;

            switch (employeeType)
            {
                case "1":
                    employee = new Employee(firstName, lastName, email, birthDay, rate);
                    break;
                case "2":
                    employee = new Manager(firstName, lastName, email, birthDay, rate);
                    break;
                case "3":
                    employee = new Sales(firstName, lastName, email, birthDay, rate);
                    break;
                case "4":
                    employee = new Accountant(firstName, lastName, email, birthDay, rate);
                    break;
                case "5":
                    employee = new Developer(firstName, lastName, email, birthDay, rate);
                    break;
                case "6":
                    employee = new JuniorDeveloper(firstName, lastName, email, birthDay, rate);
                    break;
            }

            employees.Add(employee);
            Console.WriteLine("Employee created!");
        }


        internal static void CheckForExistingEmployee()
        {
            string path = $"{directory}{fileName}";
            bool fileFound = File.Exists(path);

            if (fileFound)
            {
                Console.WriteLine("File has been exist");
            }
            else
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                    Console.Write("Directory is ready for saving file");
                }
            }
        }


        internal static void ViewALlEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                employees[i].DisplayEmployeeDetails();
            }
        }

        internal static void LoadEmployees(List<Employee> employees)
        {
            string path = $"{directory}{fileName}"; //tworze stringa przechowującego ścieżkę do pliku

            

                if (File.Exists(path)) //Ładowanie ma nastąpić tylko w przypadku istnienia pliku
                {
                    employees.Clear(); //czyszczenie załadowanej listy przed pobraniem z pliku
                    string[] employessAsString = File.ReadAllLines(path);//Utworzenie listy stringów żeby zczytywać linie

                    for (int i = 0; i < employessAsString.Length; i++)
                    {
                        //Rozbijamy wartości z ciągu dla każdego pracownika po znaku ';'
                        //i przechowujemy w liście stringów
                        string[] employeeSplits = employessAsString[i].Split(';');
                        //pobieramy wartości po kolei metodą Substring licząc od miejsca o jeden dalej od dwukropków
                        string firstName = employeeSplits[0].Substring(employeeSplits[0].IndexOf(':') + 1);
                        string lastName = employeeSplits[1].Substring(employeeSplits[1].IndexOf(':') + 1);
                        string email = employeeSplits[2].Substring(employeeSplits[2].IndexOf(":") + 1);
                        DateTime birthDay = DateTime.Parse(employeeSplits[3].Substring(employeeSplits[3].IndexOf(':') + 1));
                        double hourlyRate = double.Parse(employeeSplits[4].Substring(employeeSplits[4].IndexOf(':') + 1));
                        string employeeType = employeeSplits[5].Substring(employeeSplits[5].IndexOf(':') + 1);

                        Employee employee = null;

                        switch (employeeType)
                        {
                            case "1":
                                employee = new Employee(firstName, lastName, email, birthDay, hourlyRate);
                                break;
                            case "2":
                                employee = new Manager(firstName, lastName, email, birthDay, hourlyRate);
                                break;
                            case "3":
                                employee = new Sales(firstName, lastName, email, birthDay, hourlyRate);
                                break;
                            case "4":
                                employee = new Accountant(firstName, lastName, email, birthDay, hourlyRate);
                                break;
                            case "5":
                                employee = new Developer(firstName, lastName, email, birthDay, hourlyRate);
                                break;
                            case "6":
                                employee = new JuniorDeveloper(firstName, lastName, email, birthDay, hourlyRate);
                                break;
                        }
                        employees.Add(employee);

                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{employees.Count} employee(s) loaded\n\n");
                    Console.ResetColor();
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("File not exist");
                }
            

            //sprawdzenie przypadku istnienia pliku z informacją message i linią kodu błedu

            /*catch (FileNotFoundException fnfex)

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(fnfex.Message);
                Console.WriteLine(fnfex.StackTrace);
                //Console.ResetColor();
            }*/
            
            }

            internal static void SaveEmployees(List<Employee> employees)
            {
                string path = $"{directory}{fileName}";
                StringBuilder sb = new StringBuilder();

                foreach (Employee employee in employees)
                {
                    string type = GetEmployeeType(employee);
                    sb.Append($"firstName:{employee.FirstName};");
                    sb.Append($"lastName:{employee.LastName};");
                    sb.Append($"email:{employee.Email};");
                    sb.Append($"birthDay:{employee.BirthDay.ToShortDateString()};");
                    sb.Append($"hourlyRate:{employee.HourlyRate};");
                    sb.Append($"type:{type};");
                    sb.Append(Environment.NewLine);
                }
                File.WriteAllText(path, sb.ToString());
                Console.WriteLine("Saved succesfully");
            }

            private static string GetEmployeeType(Employee employee)
            {
                if (employee is Manager)
                    return "2";
                else if (employee is Employee)
                    return "1";
                else if (employee is Sales)
                    return "3";
                else if (employee is Accountant) return "4";
                else if (employee is Developer) return "5";
                else if (employee is JuniorDeveloper) return "6";
                return "0";
            }

            internal static void ViewEmplyeeById(List<Employee> employees)
            {
                //Blok try catch pozwala na wyłapywanie wyjątków i uruchamiania 
                //zastępczego kodu zamiast wyłączać program
                try
                {
                    Console.WriteLine("Employee Id: ");
                    int employeeId = int.Parse(Console.ReadLine());
                    Employee selectedEmployee = employees[employeeId];
                    selectedEmployee.DisplayEmployeeDetails();
                }
                catch (ArgumentOutOfRangeException aoorex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ID number is out of the range!");
                    Console.ResetColor();
                }
                catch (Exception fex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Thats not correct format ID or number is out of the range!");
                    Console.ResetColor();
                }

            }
        }
    } 

