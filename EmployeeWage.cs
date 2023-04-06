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

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int totaHours;
        private int totalEmpWage;
        public EmployeeWage(string company, int empRatePerHour, int numOfWorkingDays, int totaHours) 
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.totaHours = totaHours;
        }
        public void Mesurement()
        {

            //Varibles
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            //Compute
            while(totalEmpHrs <= this.totaHours && totalWorkingDays < this.numOfWorkingDays)
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
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            //Console.WriteLine("Total Emp wage for company: " + company + " is: " + totalEmpWage);
        }
        public string toString()
        {
            return "Total Emp wage for company: " + this.company + " is: " + this.totalEmpWage;
        }
    }
}

