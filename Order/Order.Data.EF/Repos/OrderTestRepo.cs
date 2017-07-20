using System.Collections.Generic;
using WebFletch.Order.Data.Entities;
using WebFletch.Order.Data.Core;
using System;

namespace WebFletch.Order.Data.EF.Repos
{
    public class OrderTestRepo : ITestRepo
    {
        private string _c = null;

        public OrderTestRepo(string connectionString)
        {
            _c = connectionString;
        }

        public List<OrderTestEntity> GetDataTests()
        {
            throw new NotImplementedException();
        }

        public void AddDataTest(OrderTestEntity testEntity)
        {
            throw new NotImplementedException();
        }
    }
}