using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebFletch.Order.DTO
{
    public static class DataExtensions
    {
        public static T ConvertTo<T>(this object convertFrom)
        {
            return ConvertGeneric<T>(convertFrom);
        }
        public static T Copy<T>(this T copyFrom)
        {
            var settings = new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects, ReferenceLoopHandling = ReferenceLoopHandling.Ignore };
            var json = JsonConvert.SerializeObject(copyFrom, settings);
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static T ConvertTo<T>(this Data.Entities.RecurringOrderEntity convertFrom) where T : Models.RecurringOrderModel
        {
            if (convertFrom == null) return null;
            var model = ConvertGeneric<Models.RecurringOrderModel>(convertFrom, new OrderResolver());

            var orderEntity = ConvertGeneric<Data.Entities.OrderEntity>(convertFrom);
            var orderModel = (Models.OrderModel)model;
            OrderResolver.ManualOrderConversions(orderEntity, ref orderModel);
            return (T)model;
        }

        public static T ConvertTo<T>(this Models.RecurringOrderModel convertFrom) where T : Data.Entities.RecurringOrderEntity
        {
            if (convertFrom == null) return null;
            var entity = ConvertGeneric<Data.Entities.RecurringOrderEntity>(convertFrom, new OrderResolver());

            var orderEntity = ConvertGeneric<Data.Entities.OrderEntity>(entity);
            OrderResolver.ManualOrderConversions(convertFrom, ref orderEntity);
            return (T)entity;
        }

        public static T ConvertTo<T>(this Data.Entities.OrderEntity convertFrom) where T : Models.OrderModel
        {
            if (convertFrom == null) return null;
            var model = ConvertGeneric<Models.OrderModel>(convertFrom, new OrderResolver());
            OrderResolver.ManualOrderConversions(convertFrom, ref model);
            return (T)model;
        }

        public static T ConvertTo<T>(this Models.OrderModel convertFrom) where T : Data.Entities.OrderEntity
        {
            if (convertFrom == null) return null;
            var entity = ConvertGeneric<Data.Entities.OrderEntity>(convertFrom, new OrderResolver());
            OrderResolver.ManualOrderConversions(convertFrom, ref entity);
            return (T)entity;
        }

        private static T ConvertGeneric<T>(object convertFrom, IContractResolver resolver = null)
        {
            var settings = new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects, ReferenceLoopHandling = ReferenceLoopHandling.Ignore };
            if (resolver != null) settings.ContractResolver = resolver;

            string json = "";
            if (!(convertFrom is string))
                json = JsonConvert.SerializeObject(convertFrom, settings);
            else
                json = convertFrom.ToString();

            if (typeof(T) == typeof(string))
                return (T)(object)json;
            else
                return JsonConvert.DeserializeObject<T>(json);
        }
    }
    
    public class OrderResolver : DefaultContractResolver
    {
        private List<string> _propertiesIWillConvertManually;
        public OrderResolver()
        {
            _propertiesIWillConvertManually = new List<string> { "Currency", "etc" };
        }
        protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
        {
            var properties = base.CreateProperties(type, memberSerialization);
            return properties.Where(p => !_propertiesIWillConvertManually.Contains(p.PropertyName)).ToList();
        }

        public static void ManualOrderConversions(Models.OrderModel model, ref Data.Entities.OrderEntity entity)
        {
        }

        public static void ManualOrderConversions(Data.Entities.OrderEntity entity, ref Models.OrderModel model)
        {
        }
    }
}