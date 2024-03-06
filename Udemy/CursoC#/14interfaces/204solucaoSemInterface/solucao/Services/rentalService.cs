using solucao.entities;

namespace solucao.services
{
  class rentalService
  {
    public double pricePerHour { get; private set; }
    public double pricePerDay { get; private set; }

    private brazilTaxService _brazilTaxService = new brazilTaxService();

    public rentalService(double pricePerHour, double pricePerDay)
    {
      this.pricePerHour = pricePerHour;
      this.pricePerDay = pricePerDay;
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

      double tax = _brazilTaxService.tax(basicPayment);

      carRental.invoice = new invoice(basicPayment, tax);
    }
  }
}