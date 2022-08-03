using System;

namespace EmployeeProject
{
    public class Employee
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;

        public static void Main(String[] args)
        {
            //int Is_Part_Time = 1;
            //int Is_Full_Time = 2;
            //int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            for(int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();

                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case Is_Part_Time:
                        empHrs = 4;
                        break;
                    case Is_Full_Time:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage " + empWage);
            }
            Console.WriteLine("Total Emp Wage" + totalEmpWage);
            //Random random = new Random();

            //int empCheck = random.Next(0, 3);

           /* if(empCheck == Is_Part_Time)
            {
                empHrs = 4;
            }
            else if(empCheck == Is_Full_Time)
             {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }*/


        }
    }
}