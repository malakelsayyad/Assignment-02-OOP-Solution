using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex03
{
    internal class Car : IMoveable
    {
        public int Speed { get; set; }

        public void Backward()
        {
            Console.WriteLine("Car is moving backward");
        }

        public void Forward()
        {
            Console.WriteLine("Car is moving forward");

        }

        public void Left()
        {
            Console.WriteLine("Car is moving left");

        }

        public void Right()
        {
            Console.WriteLine("Car is moving right");

        }
    }
}
