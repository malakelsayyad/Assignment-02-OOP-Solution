using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex03
{
    internal class Airplane : IMoveable , IFlyable
    {
        int IMoveable.Speed { get; set ; }

        void IMoveable.Backward()
        {
            Console.WriteLine("Airplane is moving backward");
        }

        void IFlyable.Backward()
        {
            Console.WriteLine("Airplane is flying backward");
        }

        void IMoveable.Forward()
        {
            Console.WriteLine("Airplane is moving forward");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Airplane is flying forward");
        }

        void IMoveable.Left()
        {
            Console.WriteLine("Airplane is moving left");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("Airplane is flying left");
        }

        void IMoveable.Right()
        {
            Console.WriteLine("Airplane is moving right");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("Airplane is flying backward");
        }
    }
}
