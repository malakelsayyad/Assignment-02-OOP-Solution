using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interfaces_Q1
{
    internal class Rectangle : IRectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle( double length , double width) 
        {
            Length = length;
            Width = width;
        }
        public double Area
        {
            get 
            {
                return Length * Width;
            }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape : Rectangle , Width : {Width} , Length : {Length} , Area : {Area}");
        }
    }
}
