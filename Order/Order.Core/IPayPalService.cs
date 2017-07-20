using Suamere.Utilities.Monad;
using System.Threading.Tasks;
using WebFletch.Order.Models;

namespace WebFletch.Order.Core
{
    public interface IPayPalService
    {
        Task<Maybe<string>> PreparePayPal(decimal totalNet, string currencyCode, string magicToken, string protocolAndDomain);
        Task<Maybe<bool>> PaymentValidates(decimal totalNet, string currencyCode, string payerID, string payPalToken);
    }
}