using System;
using Course.Entities.Enums;

namespace Course.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Color color, double Radius) : base(color)
        {
            this.Radius = Radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

    }
}
