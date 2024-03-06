using solucao.entities;

namespace solucao.services
{
  class rentalService
  {
    public double pricePerHour { get; private set; }
    public double pricePerDay { get; private set; }

    private ItaxService _taxService;

    public rentalService(double pricePerHour, double pricePerDay, ItaxService taxService)
    {
      this.pricePerHour = pricePerHour;
      this.pricePerDay = pricePerDay;
      this._taxService = taxService;
    }

    public void processInvoice(carRental carRental)
    {
      TimeSpan duration = carRental.finish.Subtract(carRental.start);

      double basicPayment = 0.0;
      if (duration.TotalHours <= 12.0)
      {
        basicPayment = pricePerHour * Math.Ceiling(duration.TotalHours);
      }
      else
      {
        basicPayment = pricePerDay * Math.Ceiling(duration.TotalDays);
      }

      double tax = _taxService.tax(basicPayment);

      carRental.invoice = new invoice(basicPayment, tax);
    }
  }
}