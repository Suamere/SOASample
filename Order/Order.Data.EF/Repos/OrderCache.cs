using WebFletch.Order.Data.Entities;
using WebFletch.Order.Data.Core;
using Suamere.Utilities.Monad;
using System;

namespace WebFletch.Order.Data.EF.Repos
{
    public class OrderCacheRepo : IOrderCache
    {
        private string _c = null;

        public OrderCacheRepo(string connectionString)
        {
            _c = connectionString;
        }

        public Maybe AddOrUpdateItem(OrderCacheEntity cacheItem)
        {
            throw new NotImplementedException();
        }

        public Maybe<OrderCacheEntity> GetCacheItem(string key, string region = null)
        {
            throw new NotImplementedException();
        }

        public Maybe RemoveCacheItem(string key, string region = null)
        {
            throw new NotImplementedException();
        }
    }
}