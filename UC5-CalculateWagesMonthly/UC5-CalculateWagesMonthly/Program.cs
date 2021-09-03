using System;

namespace UC5_CalculateWagesMonthly
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int empHrs=0,empWage =0,totalEmpWage = 0;
            //Computation
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
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
                Console.WriteLine("EmpWage:" + empWage);
            }
            Console.WriteLine("Total Emp Wage:" + totalEmpWage);
        }
    }
}
