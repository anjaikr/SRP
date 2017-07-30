using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLayer;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeData = new EmployeeData();
            employeeData.DisplayEmployeeData();

            EmployeeData employeeData2 = new EmployeeOracleData();
            employeeData2.DisplayEmployeeData();
            Console.ReadLine();



        }
    }
}
