using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d8_empwage_edited
{
    internal class empwage_process
    {
        public static void empAttendance(Random random)
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int workHr = 0;
            int totalEmpWage = 0;
            int totalWorkHr = 0;
            int totalDays = 0;
            while (totalWorkHr<100 && totalDays<20) {
                totalDays++;
                int empCheck = random.Next(0,3);
                switch (empCheck)
                {

                    case IS_FULL_TIME: workHr = 8; break;
                    case IS_PART_TIME: workHr = 4; break;
                    default: workHr = 0; break;

                }
                
                totalWorkHr += workHr;
                int current_wage = empDailyWage(workHr);
                totalEmpWage += current_wage;
                Console.WriteLine("Emp Wage: " + current_wage);
                
            }
            Console.WriteLine("The Total Employee Working Wage :" + totalEmpWage);
            Console.WriteLine("The Total Employee Working Days :" + (totalDays));
            Console.WriteLine("The Total Employee Working Hour :" + (totalWorkHr));



        }
        public static int empDailyWage(int empWorkHr)
        {

            int EMP_RATE_PER_HR = 20;
           
            int empWage = empWorkHr * EMP_RATE_PER_HR;
            return empWage;
        }
    }

}

