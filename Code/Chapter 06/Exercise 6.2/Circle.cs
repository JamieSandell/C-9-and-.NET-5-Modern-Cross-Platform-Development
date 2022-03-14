using System;

namespace Exercise_6._2
{
    public class Circle : Shape
    {
        public override double Area
        {
            get
            {
                return Math.PI * Math.Pow(base.Height / 2, 2);
            }
            protected set
            {

            }
        }
        public Circle(double diameter) : base(diameter, diameter)
        {

        }
    }
}