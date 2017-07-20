using System.Collections.Generic;
using WebFletch.Order.Data.Entities;

namespace WebFletch.Order.Data.Core
{
    public interface ITestRepo
    {
        List<OrderTestEntity> GetDataTests();
        void AddDataTest(OrderTestEntity testEntity);
    }
}