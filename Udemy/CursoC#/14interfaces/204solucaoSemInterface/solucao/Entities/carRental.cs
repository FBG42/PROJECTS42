namespace solucao.entities
{
  class carRental
  {
    public DateTime start { get; set; }
    public DateTime finish { get; set; }
    public vehicle vehicle { get; set; }
    public invoice invoice { get; set; }

    public carRental(DateTime start, DateTime finish, vehicle vehicle)
    {
      this.start = start;
      this.finish = finish;
      this.vehicle = vehicle;
    }
  }
}