using Ex045.Entities;

namespace Ex045.Services
{
    internal class ContractService
    {
        public int NumberOfInstallments { get; set; }

        private IPaymentService _paymentService;

        public ContractService(int numberOfInstallments, IPaymentService paymentService)
        {
            NumberOfInstallments = numberOfInstallments;
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract)
        {
            double installmentValue = contract.TotalValue / NumberOfInstallments;
            for (int i = 1; i <= NumberOfInstallments; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);

                double installmentValueMonth = installmentValue + _paymentService.MonthFee(i, installmentValue);
                double installmentTotalValue = installmentValueMonth + _paymentService.PaymentFee(installmentValueMonth);
                Installment installment = new Installment(dueDate, installmentTotalValue);
                
                contract.AddInstallment(installment);
            }
        }
    }
}
