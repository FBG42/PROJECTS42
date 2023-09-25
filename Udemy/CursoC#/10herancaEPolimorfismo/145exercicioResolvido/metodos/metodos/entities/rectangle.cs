using metodos.entities.enums;

namespace metodos.entities
{
    internal class rectangle : shape
    {
        public double width { get; set; }
        public double height { get; set; }

        public rectangle(double width, double height, color color): base(color)
        {
            this.width = width;
            this.height = height;
        }

        public override double area()
        {
            return width * height;
        }
    }
}
