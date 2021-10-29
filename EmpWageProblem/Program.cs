using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem
{
    class Program
    {
        public static void Main(String[] args)
        {
            UC9TotWageEachCompany dMart = new UC9TotWageEachCompany("DMart", 20, 2, 10);
            UC9TotWageEachCompany Vguard = new UC9TotWageEachCompany("Vguard", 10, 2, 10);
            UC9TotWageEachCompany reliance = new UC9TotWageEachCompany("Reliancet", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.ToString());
            Vguard.computeEmpWage();
            Console.WriteLine(Vguard.ToString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.ToString());

            Console.ReadLine();

        }
    }
}
