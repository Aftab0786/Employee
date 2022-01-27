using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeWageComputation
    {
        // Constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 10;
        //variables
        int empHrs = 0;
        int totalEmpHrs = 0;
        int totalEmpWage = 0;
        int totalWorkingDays = 0;
        //Methods
        public void MonthlyWage()
        {
            //UC 6:Calculating wages till number of working days or total working hours per  month is reached.
            while (totalEmpWage <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                Random random = new Random();
                //Computation.
                int empCheck = random.Next(0, 3);
                totalWorkingDays++;
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                //formula for Employee Wage Calculation.
                totalEmpHrs += empHrs;
                Console.WriteLine("Day# : " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage is : " + totalEmpWage);
        }
    }
}
