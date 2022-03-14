namespace Exercise_6._2
{
    public class Rectangle : Shape
    {
        public override double Area
        {
            get
            {
                return base.Width * base.Height;
            }
            protected set
            {

            }
        }
        public Rectangle(double height, double width) : base(height, width)
        {

        }
    }
}