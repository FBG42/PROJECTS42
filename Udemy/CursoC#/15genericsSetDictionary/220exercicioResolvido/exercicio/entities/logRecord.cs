using System;

namespace exercicio.entities
{
    public class logRecord
    {
        public string username { get; set; }
        public DateTime isntant { get; set; }

        public override int GetHashCode()
        {
            return username.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is logRecord))
            {
                return false;
            }
            logRecord other = obj as logRecord;
            return username.Equals(other.username);
        }
    }
}
