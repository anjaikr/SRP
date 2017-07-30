using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class EmployeeOracleData : EmployeeData
    {
        public override void DisplayEmployeeData()
        {
            DisplayEmployee displayEmployee = new DisplayEmployeeOracleData();
            displayEmployee.DisplayEmployeeData();
        }
    }

}
