using Demo.Inteface_Ex02;
using Demo.Interface_Ex01;
using Demo.Interface_Ex03;
using System.Text;

namespace Demo
{
    internal class Program
    {
        //static void Print10Numbers(SeriesByTwo series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //static void Print10Numbers(SeriesByThree series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //static void Print10Numbers(SeriesByFour series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}
        //static void Print10Numbers(ISeries series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}


        static void Main(string[] args)
        {
            #region Interfaces Ex01
            // Interfaces : Reference type
            // Code contract between the developer who wrote it and the dveloper who will use it

            //IMyType myType = new IMyType(); // Invalid
            //myType.MyFun();

            //Note : cant create an object 

            // Can create reference from interface and this reference can refer to object
            // from class which implement the interface


            //MyType myType = new MyType();
            //myType.MyFun();
            //myType.Salary = 12000;
            //Console.WriteLine(myType.Salary);
            //myType.Print();

            //IMyType myType = new MyType();

            //myType.MyFun();
            //myType.Print(); 
            #endregion

            #region Interfaces Ex02
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //Print10Numbers(seriesByTwo);
            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10Numbers(seriesByThree);
            //SeriesByFour seriesByFour = new SeriesByFour();
            //Print10Numbers(seriesByFour);

            //int[] Numbers = { 7, 6, 5, 4, 3, 2, 1, 8, 9 };

            //Array.Sort(Numbers);

            //foreach (var item in Numbers)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //Employee[] employees = new Employee[3]
            //{
            //    new Employee(){Id=1,Name = "Ahmed", Age=30, Salary=12000 },
            //    new Employee(){Id=1,Name = "Omar", Age=27, Salary=12000 },
            //    new Employee(){Id=1,Name = "Ali", Age=28, Salary=12000 },
            //};

            //Array.Sort(employees);
            //foreach (Employee item in employees)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Interfaces Ex03
            //Car car = new Car();
            //car.Speed = 120;
            //car.Forward();

            //Airplane airplane = new Airplane();

            //IMoveable moveable = airplane;
            //moveable.Forward();

            //IFlyable flyable = airplane;
            //flyable.Forward(); 
            #endregion

            #region Shallow Copy Vs Deep Copy

            // 1.Shallow Copy

            //int[] Arr1 = { 1, 2, 3 };
            //int[] Arr2 = { 4, 6, 5 };

            // string[] Arr1 = { "Ahmed", "Ali", "Omar" };
            // string[] Arr2 = { "Ziad", "Adel", "Amr" };


            // Console.WriteLine($"Arr1:{Arr1.GetHashCode()}");
            // Console.WriteLine($"Arr1:{Arr2.GetHashCode()}");

            //Arr2 = Arr1; // Shallow copy
            // Copy Identity
            // { 1, 2, 3 } --> Has two references Arr1 & Arr2
            // { 4, 6, 5 } --> Unreachable Object


            //Console.WriteLine();
            //Console.WriteLine($"Arr1:{Arr1.GetHashCode()}");
            //Console.WriteLine($"Arr1:{Arr2.GetHashCode()}");

            // Identity [Address]+ Object Satate [Data]

            //Arr2[0] = "Ahmed amin";
            //Console.WriteLine(Arr1[1]);


            //Arr2[0]= 100;
            //Console.WriteLine(Arr1[0]);

            // 2.Deep Copy

            //int[] Arr1 = { 1, 2, 3 };
            //int[] Arr2 = { 4, 6, 5 };


            // Console.WriteLine($"Arr1:{Arr1.GetHashCode()}");
            // Console.WriteLine($"Arr1:{Arr2.GetHashCode()}");

            // Arr2 = (int[]) Arr1.Clone(); // Deep copy
            // Clone method will copy the object state of the caller
            // Assigns the new object to Arr2 , will generat new identity 


            // Console.WriteLine();
            // Console.WriteLine($"Arr1:{Arr1.GetHashCode()}");
            // Console.WriteLine($"Arr1:{Arr2.GetHashCode()}");

            // Identity [Address]+ Object Satate [Data]

            // Arr2[0] = 100;
            // Console.WriteLine(Arr1[0]);

            // StringBuilder[] Arr1 = new StringBuilder[]
            // {
            //     new StringBuilder("Ahmed"),
            //     new StringBuilder("Ali"),
            //     new StringBuilder("Omar"),
            //};

            // StringBuilder[] Arr2 = new StringBuilder[]
            //  {
            //     new StringBuilder("Amr"),
            //     new StringBuilder("Adel"),
            //     new StringBuilder("Ziad"),
            // };

            // Arr2 = (StringBuilder[])Arr1.Clone();

            // Arr2[0].Append("Ahmed amin");

            #endregion

            #region Built-In Interface ICloneable
            // Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 30, Salary = 12000 };
            // Employee E02 = new Employee() { Id = 2, Name = "Amr", Age = 27, Salary = 12000 };

            //E02 = E01; // Shallow copy
            //E02 = (Employee)E01.Clone(); // Deep copy

            //E01.Salary = 13000;

            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());

            //Console.WriteLine(E01);
            //Console.WriteLine(E02); 
            #endregion

            #region Built-In Interface IComparable

            // Employee[] employees = new Employee[3]
            // {
            //     new Employee(){Id=1,Name = "Ahmed", Age=30, Salary=12000 },
            //     new Employee(){Id=1,Name = "Omar", Age=27, Salary=12000 },
            //     new Employee(){Id=1,Name = "Ali", Age=28, Salary=12000 },
            // };

            // Array.Sort(employees);

            //int X = employees[0].CompareTo(employees[1]);
            // +ve : Caller greater than Parameter
            // -ve : Caller less than Parameter
            // 0 : Caller = Parameter

            //Console.WriteLine(X);

            //foreach (Employee item in employees)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Built-In Interface IComparer

            //Employee[] employees = new Employee[3]
            //{
            //     new Employee(){Id=1,Name = "Ahmed", Age=30, Salary=12000 },
            //     new Employee(){Id=1,Name = "Omar", Age=27, Salary=11000 },
            //     new Employee(){Id=1,Name = "Amr", Age=28, Salary=13000 },
            //};

            //Array.Sort(employees,new EmployeeComparerSalary());
            //Array.Sort(employees,new EmployeeComparerNameLength());

            //foreach (Employee item in employees)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
        }
    }
}
