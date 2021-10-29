using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderList empWageBulder = new EmpWageBuilderList();
            empWageBulder.addCompanyEmpWage("D-Mart", 20, 6, 20);
            empWageBulder.addCompanyEmpWage("Reliance", 20, 6, 20);
            empWageBulder.computeEmpWage("cloth-centre",8,15,8);
            Console.WriteLine("Total Emp wage D-Mart company:" + ComputeEmpWage.getTotalWage("D-mart"));
            Console.ReadLine();
        }
    }
}
