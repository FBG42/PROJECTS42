namespace exercicio
{
    internal class room
    {
        public string tenantName { get; set; }
        public string tenantEmail { get; set; }
        public int roomNumber { get; set; }


        public override string ToString()
        {
            return $"{tenantName}, {tenantEmail}";
        }
    }
}
