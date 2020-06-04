using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CollectionDemoConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> employeeList = new Dictionary<int,Employee>();
            employeeList.Add(1, new Employee("fred",1));
            employeeList.Add(2, new Employee("Josh",2));
            employeeList.Add(3, new Employee("Jack",3));
            employeeList.Add(4, new Employee("Boby",4));
            employeeList.Add(5, new Employee("Paul",5));

            foreach(KeyValuePair<int,Employee> var in employeeList)
            {
                Console.WriteLine("Employee ID:{0}, Name: {1}, Age:{2}, Salary:{3}, Gender :{4} ",
                    var.Value.Id,var.Value.Name,var.Value.Age,var.Value.Salary,var.Value.Gender);
            }
        }
    }
}
