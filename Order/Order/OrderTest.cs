using System.Collections.Generic;
using Suamere.Utilities.Monad;
using WebFletch.Order.Models;
using WebFletch.Order.Data.Core;
using WebFletch.Order.DTO;
using WebFletch.Order.Data.Entities;
using System.Linq;

namespace WebFletch.Order
{
    public class OrderTest : Core.ITestOrders
    {
        private ITestRepo _testRepo;

        public OrderTest(ITestRepo testRepo)
        {
            _testRepo = testRepo;
        }

        public Maybe AddTestRecord(TestModel Description)
        {
            _testRepo.AddDataTest(Description.ConvertTo<OrderTestEntity>());
            return Maybe.Success();
        }
        
        public Maybe<List<TestModel>> GetTestRecords()
        {
            var tests = _testRepo.GetDataTests().Select(x => x.ConvertTo<TestModel>()).ToList();
            return tests.ToMaybe();
        }
    }
}