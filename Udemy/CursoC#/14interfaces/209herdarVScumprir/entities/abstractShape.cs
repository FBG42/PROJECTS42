using System;
using herdarVScumprir.enums;

namespace herdarVScumprir.entities
{
    public abstract class abstractShape: Ishape
    {
        public color color { get; set; }

        public abstract double area();
    }
}
