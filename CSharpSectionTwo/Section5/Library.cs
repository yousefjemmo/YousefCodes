using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5
{
    internal class Employee
    {
        
        public uint EmployeeID;
        public string EmployeeName;
        public double SalaryPerHour;
        public double NoOfWorkingHours;
        public double NetSalary;

       
        public static string OrganizationName;

       
        public const string TypeOfEmployee = "Contract Based";

        
        public readonly string DepartmentName;

        public Employee()
        {
           
            DepartmentName = "Finance Department";
        }
    }
}
