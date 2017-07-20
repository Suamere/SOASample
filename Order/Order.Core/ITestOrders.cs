using Suamere.Utilities.Monad;
using System.Collections.Generic;
using WebFletch.Order.Models;

namespace WebFletch.Order.Core
{
    public interface ITestOrders
    {
        Maybe AddTestRecord(TestModel Description);
        Maybe<List<TestModel>> GetTestRecords();
    }
}