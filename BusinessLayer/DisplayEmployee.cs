using System;

namespace BusinessLayer
{
    public class DisplayEmployee
    {
        public virtual void DisplayEmployeeData()
        {
            string empData = new DataFormatter().FormatEmployeeData();
            Console.WriteLine("Displaying Employee Data as below:");
            Console.WriteLine(empData);
        }
    }
}