﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_WageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWageComputation program"); // printing message on console 
            CalculationofEmpWage.WageCompute("Dmart", 50, 110, 44);    //calling static Method with parameters.
            CalculationofEmpWage.WageCompute("Reliance", 88, 100, 30);
            CalculationofEmpWage.WageCompute("Flipkart", 35, 130, 15);
            Console.ReadLine();
        }
    }
}
