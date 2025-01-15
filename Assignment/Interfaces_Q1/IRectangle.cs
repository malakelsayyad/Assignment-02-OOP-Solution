using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interfaces_Q1
{
    public interface IRectangle : IShape
    {

        double Width { get; set; }
        double Length { get; set; }
    }
}
