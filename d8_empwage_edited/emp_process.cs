using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d8_empwage_edited
{
    internal class empwage_process
    {






        public static void empAttendance(int random)
        {
            

            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int workHr = 0;

            int empCheck = random;
            if (empCheck == IS_FULL_TIME)
            {
                workHr = 8;

            }
            else if (empCheck == IS_PART_TIME) 
            {
                workHr = 4;
            }

            else
            {
                workHr = 0;

            }

            Console.WriteLine("Emp Wage: " + empDailyWage(workHr));

        }
        public static int empDailyWage(int empWorkHr)
        {

            int EMP_RATE_PER_HR = 20;
           
            int empWage = empWorkHr * EMP_RATE_PER_HR;
            return empWage;
        }
    }

}

