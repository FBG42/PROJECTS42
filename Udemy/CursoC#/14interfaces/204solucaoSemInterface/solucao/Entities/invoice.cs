namespace solucao.entities
{
  class invoice
  {
    public double basicPayment { get; set; }
    public double tax { get; set; }

    public invoice(double basicPayment, double tax)
    {
      this.basicPayment = basicPayment;
      this.tax = tax;
    }

    public double TotalPayment {
      get { return basicPayment + tax;}
    }

    public override string ToString()
    {
        return $"Basic payment: {basicPayment:F2} \nTax: {tax:F2} \nTotalPayment: {TotalPayment:F2}";
    }
  }
}