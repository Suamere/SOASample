using Suamere.Utilities.Monad;
using System.Threading.Tasks;
using WebFletch.Order.Core;
using WebFletch.Order.Data.Core;

namespace WebFletch.Order
{
    public class PayPalService : IPayPalService
    {
        private IPaymentRepo _paymentRepo;

        public PayPalService(IPaymentRepo paymentRepo)
        {
            _paymentRepo = paymentRepo;
        }

        public async Task<Maybe<string>> PreparePayPal(decimal totalNet, string currencyCode, string magicToken, string protocolAndDomain)
        {
            return await Task.FromResult("".ToMaybe());
        }

        public async Task<Maybe<bool>> PaymentValidates(decimal totalNet, string currencyCode, string payerID, string payPalToken)
        {
            return await Task.FromResult(false.ToMaybe());
        }
    }
}