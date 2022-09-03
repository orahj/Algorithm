using System;
using System.Collections.Generic;

namespace HashBaseDataStructure
{
    class Employee
    {
        string name;
        int id;
        string department;

        public Employee(string name, int id, string department)
        {
            this.name = name;
            this.id = id;
            this.department = department;
        }

        static void Main(string[] args)
        {
            Employee employee = new Employee("Isaac", 29394, "IT");
            Employee employee1 = new Employee("Tosin", 30940, "Sales");
            Employee employee2 = new Employee("Josh", 848484, "Food and Enjoyment");

            Dictionary<int, Employee> employeeById = new Dictionary<int, Employee>();
            employeeById.Add(employee.id, employee);
            employeeById.Add(employee1.id, employee1);
            employeeById.Add(employee2.id, employee2);

            Employee e;

            if(employeeById.TryGetValue(30940,out e))
            {
                Console.WriteLine(e.name + " : " + e.department);
            }

            //employeeById.ContainsKey()

            //for HAshSet we can use this structure when all record is unique and order does not matter.

            HashSet<string> productCodes = new HashSet<string>();
            productCodes.Add("DK04030");
            productCodes.Add("CHS39403");
            productCodes.Add("TAS39202");
            productCodes.Add("KAL0192334");

            productCodes.Contains("KSKDSKD93939");//this returns false

            productCodes.Contains("CHS39403"); //this returns true

            //Major difference between Hashset and Dictionary is that for Hashset the entire data is unique and for Dictionaries the Keys are unique.




        }
    }
}
