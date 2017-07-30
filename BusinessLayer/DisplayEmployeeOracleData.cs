using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class DisplayEmployeeOracleData : DisplayEmployee
    {
        public override void DisplayEmployeeData()
        {
            DataFormatter dataFormatter = new OracleDataFormatter();
            string empData = dataFormatter.FormatEmployeeData();
            Console.WriteLine("Displaying Employee Data for Oracle Database as below:");
            Console.WriteLine(empData);
        }
    }

}
