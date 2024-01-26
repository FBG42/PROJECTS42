using metodos.entities.enums;

namespace metodos.entities
{
    internal class circle: shape
    {
        public double radius { get; set; }

        public circle(double radius, color color): base(color)
        {
            this.radius = radius;
        }

        public override double area()
        {
            return Math.PI * radius * radius;
        }
    }
}
