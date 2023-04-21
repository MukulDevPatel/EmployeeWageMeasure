using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 2000, 26, 100);
            empWageBuilder.addCompanyEmpWage("TATA", 2100, 24, 100);
            empWageBuilder.computeEmpWage();
        }
    }
}
