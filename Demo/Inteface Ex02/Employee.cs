using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inteface_Ex02
{
    class EmployeeComparerNameLength : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee X = (Employee)x;
            Employee Y = (Employee)y;

            if (X.Name.Length > Y.Name.Length) return 1;
            else if (X.Name.Length < Y.Name.Length) return -1;
            else return 0;
        }
    }
    class EmployeeComparerSalary : IComparer
    {
        public int Compare(object? x, object? y)
        {  
            Employee X = (Employee)x;
            Employee Y = (Employee)y;

           if (X.Salary > Y.Salary) return 1;
           else if (X.Salary < Y.Salary) return -1;
           else return 0;
        }
    }
    internal class Employee : IComparable 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public double Salary { get; set; }

        public Employee() 
        {
        }
        public Employee(Employee employee) 
        {
            Id = employee.Id;
            Name = employee.Name;
            Age = employee.Age;
            Salary = employee.Salary;
        }
        public object Clone()
        {
            return new Employee(this);
           // return new Employee() { Id = this.Id, Name = this.Name, Age = this.Age, Salary = this.Salary };
        }

        public int CompareTo(object? obj)
        {   
            Employee e = (Employee) obj ;

            //if (this.Age > e.Age)    return 312;
            //else if (this.Age < e.Age) return -312;
            //else return 0;

            return this.Age.CompareTo(e.Age);
        }

        public override string ToString()
        {
            return $"Id : {Id}, Name : {Name} , Salary : {Salary}, Age:{Age} ";
        }

    }
}
