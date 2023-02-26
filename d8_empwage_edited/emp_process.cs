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
            

            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int workHr = 0;

            int empCheck = random;

            switch (empCheck)
            {

                case IS_FULL_TIME: workHr = 8; break;
                case IS_PART_TIME: workHr = 4;break;
                default: workHr = 0;break;
            
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

