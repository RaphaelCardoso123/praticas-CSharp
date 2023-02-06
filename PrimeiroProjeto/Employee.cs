using System;
using System.Collections.Generic;
using System.Globalization;


namespace PrimeiroProjeto {
    internal class Employee {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }


        //CONSTRUTOR
        public Employee (int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }   

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }

        //OVERRIDE
        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
