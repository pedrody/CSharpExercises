namespace Ex045.Services
{
    internal class PaypalService : IPaymentService
    {

        public double monthFeePercentage = 0.01;
        public double paymentFeePercentage = 0.02;

        public double MonthFee(int month, double amount)
        {
            return amount * monthFeePercentage * month;
        }

        public double PaymentFee(double amount)
        {
            return amount * paymentFeePercentage;
        }
    }
}
