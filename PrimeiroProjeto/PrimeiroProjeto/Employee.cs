using System;
using System.Collections.Generic;


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



    }
}
