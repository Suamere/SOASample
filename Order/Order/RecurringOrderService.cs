using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebFletch.Order.Core;
using WebFletch.Order.Data.Core;
using WebFletch.Order.Models;

namespace WebFletch.Order
{
    public class RecurringOrderService : OrderService, IRecurringOrderService
    {
        private IPaymentService _paymentService;
        private IOrderCache _orderCache;
        private IOrderRepo _orderRepo;

        public RecurringOrderService(IPaymentService paymentService, IOrderRepo orderRepo, IOrderCache cache) : base(orderRepo, cache)
        {
            _paymentService = paymentService;
            _orderCache = cache;
            _orderRepo = orderRepo;
        }

        public async Task<RecurringOrderResponseModel> CreateEnrollmentRecurringOrder(RecurringOrderModel order, int marketID, int languageID)
        {
            return await Task.FromResult(new RecurringOrderResponseModel());
        }

        public List<KeyNamePair<int, string>> RecurringOrderFrequencies()
        {
            throw new NotImplementedException();
        }
    }
}