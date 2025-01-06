using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inteface_Ex02
{
    internal class SeriesByTwo : ISeries
    {
        public int Current { get ; set ; } // 0

        public void Next()
        {
            Current += 2;
        }
        


    }
}
