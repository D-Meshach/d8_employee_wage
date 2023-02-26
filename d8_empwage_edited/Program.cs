using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d8_empwage_edited
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Employee Wage Problem");
            Random random = new Random();
            empwage_process.empAttendance(random);
            

        }
    }
}
