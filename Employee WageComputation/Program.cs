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
            CalculationofEmpWage company = new CalculationofEmpWage();
            company.AddCompany("Dmart", 50, 110, 44);
            company.AddCompany("Reliance", 88, 100, 30);
            company.AddCompany("Flipkart", 35, 130, 15);
            company.GetWage();
            Console.ReadLine();
        }
    }
}
