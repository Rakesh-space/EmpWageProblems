using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem
{
    class UC1CheckEmpPreAbse
    {
        static void main(String[] args)
        {
            int IS_FULL_TIME = 1;   //here integer type varable assigned to value
            Random random = new Random(); //here use Random class 

            int empCheck = random.Next(0, 2);  //here pass the possiblilites of random class
            if (empCheck == IS_FULL_TIME)  //here cheked the employee is full time or not
            {
                Console.WriteLine("\n Employee Present..");
            }
            else
            {
                Console.WriteLine("\n Employee is Absent..");
            }
            Console.ReadLine();
        }
    }
}
