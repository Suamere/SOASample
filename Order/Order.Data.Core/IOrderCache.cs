using Suamere.Utilities.Monad;
using System.Collections.Generic;
using WebFletch.Order.Data.Entities;

namespace WebFletch.Order.Data.Core
{
    public interface IOrderCache
    {
        Maybe AddOrUpdateItem(OrderCacheEntity cacheItem);
        Maybe<OrderCacheEntity> GetCacheItem(string key, string region = null);
        Maybe RemoveCacheItem(string key, string region = null);
    }
}