using System;

namespace herdarVScumprir.entities
{
    public class rectangle : abstractShape
    {
        public double width { get; set; }
        public double height { get; set; }

        public override double area()
        {
            return width * height;
        }

        public override string ToString()
        {
            return $"Rectangle color = {color}, width = {width:F2}, height = {height:F2}, area = {area():F2}";
        }
    }
}
