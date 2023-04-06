using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {

            EmployeeWage dMart = new EmployeeWage("DMart", 20, 20, 100);
            dMart.Mesurement();
            Console.WriteLine(dMart.toString());
            EmployeeWage tata = new EmployeeWage("TATA", 20, 10, 100);
            tata.Mesurement();
            Console.WriteLine(tata.toString());
        }
    }
}
