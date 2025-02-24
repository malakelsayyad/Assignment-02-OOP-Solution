﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interfaces_Q1
{
    public class Circle : ICircle
    {
    
        public double Radius { get ; set ; }

        public double Area
        {
            get
            {
                return Math.PI*Radius*Radius;
            }

        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: Circle , Radius : {Radius} , Area : {Area}");
        }
    }
}
