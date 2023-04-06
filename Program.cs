using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage employee = new EmployeeWage();
            employee.Mesurement("DMart",20, 20, 100);
            employee.Mesurement("TATA", 20, 10, 100);
        }
    }
}
