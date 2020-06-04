using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemoConApp
{
    class Employee
    {
        public Employee(string name, int id = 0, int age = 0, double salary = 0, string gender = "N/A")
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
            this.Salary = salary;
            this.Gender = gender;
        }

        public Employee(int id, string name, int age, double salary, string gender)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
            this.Gender = gender;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }
    }
}
