using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d8_empwage_edited
{
    internal class empwage_process
    {






        public static int empAttendance()
        {


            int IS_FULL_TIME = 1;
            int workHr = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                workHr = 8;

            }

            else
            {
                workHr = 0;

            }

            return workHr;

        }






        public static void empDailyWage()
        {

            int EMP_RATE_PER_HR = 20;
            int empWorkHr = empAttendance();
            if (empWorkHr == 0)
            {
                Console.WriteLine("Employee is Absent");
            }



            else

            {
                int empWage = empWorkHr * EMP_RATE_PER_HR;
                Console.WriteLine("Emp Wage: " + empWage);
            }





        }




    }

}

