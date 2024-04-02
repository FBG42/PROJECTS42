using System;

namespace exercicio
{
    public class student
    {
        public int id { get; set; }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is student))
            {
                return false;
            }
            student other = obj as student;
            return id.Equals(other.id);
        }
    }
}
