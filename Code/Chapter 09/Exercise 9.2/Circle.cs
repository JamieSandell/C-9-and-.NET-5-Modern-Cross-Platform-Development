using System;

namespace Exercise_9._2
{
    public class Circle : Shape
    {
        public override double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }
        public double Radius { get; set; }
    }
}