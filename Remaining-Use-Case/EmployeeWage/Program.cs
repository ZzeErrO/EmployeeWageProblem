﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject empWageBuilder = new EmpWageBuilderObject();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            //Console.WriteLine("Total Wage for DMart company: "+empWageBuilder.getTotalWage("DMart"));
            Console.WriteLine("Press any key to exit....");
            Console.ReadKey();
        }
    }
}
