namespace Ex044.Services
{
    internal class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            return amount <= 100.00 ? amount * 0.20 : amount * 0.15;
        }
    }
}
