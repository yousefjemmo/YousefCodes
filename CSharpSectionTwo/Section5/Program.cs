using System;

namespace Section5
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Employee.OrganizationName = "Harsha Inc.";
            Console.WriteLine("******* " + Employee.OrganizationName + " *******");
            
            for (int i = 0; i < 10; i++)
            {
               
                string employeeNumber;
                switch (i)
                {
                    case 0: employeeNumber = "FIRST EMPLOYEE:";
                        break;
                    case 1: employeeNumber = "SECOND EMPLOYEE:"; 
                        break;
                    case 2: employeeNumber = "THIRD EMPLOYEE:";
                        break;
                    case 3: employeeNumber = "FOURTH EMPLOYEE:";
                        break;
                    case 4: employeeNumber = "FIFTH EMPLOYEE:";
                        break;
                    case 5: employeeNumber = "SIXTH EMPLOYEE:";
                        break;
                    case 6: employeeNumber = "SEVENTH EMPLOYEE:";
                        break;
                    case 7: employeeNumber = "EIGHTH EMPLOYEE:";
                        break;
                    case 8: employeeNumber = "NINTH EMPLOYEE:";
                        break;
                    case 9: employeeNumber = "TENTH EMPLOYEE:";
                        break;
                    default: employeeNumber = "OTHER EMPLOYEE:";
                        break;
                }
                Console.WriteLine(employeeNumber);

                
                Employee emp = new Employee();

                 
                Console.Write("Employee ID: ");
                emp.EmployeeID = uint.Parse(Console.ReadLine());

                
                Console.Write("Employee Name: ");
                emp.EmployeeName = Console.ReadLine();

               
                Console.Write("Salary per Hour: ");
                emp.SalaryPerHour = uint.Parse(Console.ReadLine());

                
                Console.Write("No. of Working Hours: ");
                emp.NoOfWorkingHours = uint.Parse(Console.ReadLine());

                
                emp.NetSalary = emp.NoOfWorkingHours * emp.SalaryPerHour;

                
                Console.WriteLine("DETAILS OF " + employeeNumber);
                Console.WriteLine("Employee ID: " + emp.EmployeeID);
                Console.WriteLine("Employee Name: " + emp.EmployeeName);
                Console.WriteLine("Salary per Hour: " + emp.SalaryPerHour);
                Console.WriteLine("No. of Working Hours: " + emp.NoOfWorkingHours);
                Console.WriteLine("Net Salary: " + emp.NetSalary);
                Console.WriteLine("Type of Employee: " + Employee.TypeOfEmployee);
                Console.WriteLine("Department Name: " + emp.DepartmentName);

                Console.Write("Do you want to continue to next employee? Yes / No: ");
                string choice = Console.ReadLine();

                if (!(choice == "yes" || choice == "YES" || choice == "Yes" || choice == "y" || choice == "Y"))
                {
                    break;
                }

               
            }

            
            
        }
    }
}
