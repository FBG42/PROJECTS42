using metodos.entities.enums;

namespace metodos.entities
{
    abstract class shape
    {
        public color color { get; set; }

        public shape(color color)
        {
            this.color = color;
        }

        public abstract double area();
    }
}
