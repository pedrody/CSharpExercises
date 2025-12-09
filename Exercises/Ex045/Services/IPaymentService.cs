namespace Ex045.Services
{
    interface IPaymentService
    {
        public double MonthFee(int month, double amount);
        public double PaymentFee(double amount);
    }
}
