using System;

namespace EmployeeProject
{
    public class Employee
    {
       public static void Main(String[] args)
        {
            int Is_Full_Time = 1;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();

            int empCheck = random.Next(0, 2);

            if(empCheck == Is_Full_Time)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage " + empWage);
        }
    }
}