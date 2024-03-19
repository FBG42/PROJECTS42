using System;

namespace herdarVScumprir.entities
{
    public class circle : abstractShape
    {
        public double radius { get; set; }

        public override double area() {
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return $"Circle color = {color}, radius = {radius:F2}, area = {area():F2}";
        }
    }
}
