using System;
using System.Collections.Generic;
using System.Text;

namespace day4
{

    class Class1
    {
        public static void GetAttendence()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
            Console.ReadKey();

        }
    }
}
