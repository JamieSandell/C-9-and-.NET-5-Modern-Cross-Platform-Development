using System;

namespace Exercise_6._2
{
    public class Square : Shape
    {
        public override double Area
        { 
            get
            {
                return base.Height * base.Width;
            }
            protected set
            {

            }
        }
        public Square(double height) : base (height, height)
        {

        }
    }
}