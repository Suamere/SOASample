using System.Collections.Generic;
using System.Threading.Tasks;
using WebFletch.Order.Models;

namespace WebFletch.Order.Core
{
    public interface IRecurringOrderService
    {
        List<KeyNamePair<int, string>> RecurringOrderFrequencies();
        Task<RecurringOrderResponseModel> CreateEnrollmentRecurringOrder(RecurringOrderModel order, int marketID, int languageID);
    }
}