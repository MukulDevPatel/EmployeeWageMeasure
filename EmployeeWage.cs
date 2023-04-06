using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWage
    {
        public const int IS_PART_TIME = 1, IS_FULL_TIME = 2, EMP_RATE_PER_HOUR = 20, TOTAL_WORKING_DAYS = 20, TOTAL_WORKING_HRS = 100;
        public void Mesurement()
        {

            //Varibles
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            //Compute
            while(totalEmpHrs <= TOTAL_WORKING_HRS && totalWorkingDays < TOTAL_WORKING_DAYS)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day: " + totalWorkingDays + "Emp Hrs: " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp wage: " + totalEmpWage);
        }
    }
}
