 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex01
{
    internal interface IMyType
    {
        // what can be written inside interface
        // 1.Signature of method (Name, Return type , Parameters)
        // 2.Signature of property
        // 3.Default implemented method (full implemented)

        // 1.Signature of method
        void MyFun();

        // 2.Signature of property
        double Salary { get; set; } // Automatic property

        // 3.Default implemented method
        void Print()
        {
            Console.WriteLine("Default implemented method (full implemented)");
        }

    }
}
