using System;
using Course.Entities.Enums;

namespace Course.Entities
{
    abstract class Shape
   {
        protected Color color { get; set; }

        public Shape(Color color) 
        {
            this.color = color;
        }

        public abstract double Area();

    }
}
