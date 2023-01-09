using Course.Entities.Enums;
using System;

namespace Course.Entities
{
    internal class Rectangle : Shape
    {
        protected double Width { get; set; }
        protected double Height { get; set; }

        public Rectangle(Color color, double Width, double Height) : base(color)
        { 
            this.Width = Width;
            this.Height = Height;
        }

        public override double Area()
        {
            return Width* Height;
        }
    }
}
