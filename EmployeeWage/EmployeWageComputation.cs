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
        
        //variables
       public static int empHrs = 0;
        public static int totalEmpHrs = 0;
        public static int totalEmpWage = 0;
        public static int totalWorkingDays = 0;
        //Methods
        public static int ComputeEmployeWageComputation(string Company, int empRatePerHour, int numOfWorkingDays,int maxHourMonth)
        {
            Random random = new Random();
            //UC 8: compute total employee wage of a comapany.

            while (totalEmpWage <= maxHourMonth && totalWorkingDays < numOfWorkingDays)
            {
                
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
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Company EMP Wage is: " + Company + "" + totalEmpWage);
            return totalEmpWage;
        }
    }
}
