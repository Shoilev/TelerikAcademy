﻿namespace Shapes
{
    // Define class Triangle that implements CalculateSurface
    // and returns the surface of the figure (height*width/2).
    public class Triangle : Shape
    {
        public Triangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width / 2;
        }

        public override string ToString()
        {
            return "Triangle";
        }
    }
}
