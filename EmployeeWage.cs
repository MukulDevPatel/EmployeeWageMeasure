using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWage
    {
        public const int IS_PART_TIME = 1, IS_FULL_TIME = 2;
        public int Mesurement(string company, int empRatePerHour,int numOfWorkingDays, int totaHours)
        {

            //Varibles
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            //Compute
            while(totalEmpHrs <= totaHours && totalWorkingDays < numOfWorkingDays)
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
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp wage for company: " + company+ " is: " + totalEmpWage);
            return totalEmpWage;
        }
    }
}
