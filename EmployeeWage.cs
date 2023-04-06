using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWage
    {
        public const int IS_PART_TIME = 1, IS_FULL_TIME = 2, EMP_RATE_PER_HOUR = 20, TOTAL_WORKING_DAYS = 20;
        public void Mesurement()
        {

            //Varibles
            int empHrs = 0, empWage = 0, totalEmpWage = 0;

            //Compute
            for (int day = 0; day < TOTAL_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage: " + empWage);
            }
            Console.WriteLine("Total Emp wage: " + totalEmpWage);
        }
    }
}
