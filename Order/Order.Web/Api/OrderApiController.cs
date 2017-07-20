using Suamere.Utilities.Monad;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebFletch.Order.Models;

namespace WebFletch.Order.Web.Api
{
    public class OrderApiController : ApiController
    {
        private Core.IOrderService _orderSvc;

        public OrderApiController(Core.IOrderService orderSvc)
        {
            _orderSvc = orderSvc;
        }

        [HttpGet]
        [Route("api/Orders/GetOrderDetailsForCustomerInDateRange/{customerID:int}/{fromDateInt:int}/{toDateInt:int}")]
        [ResponseType(typeof(List<OrderModel>))]
        public HttpResponseMessage GetOrderDetailsForCustomerInDateRange(int customerID, int fromDateInt, int toDateInt)
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.InternalServerError);
        }

        [HttpGet]
        [Route("api/Orders/GetOrdersInDateRange/{fromDateInt:int}/{toDateInt:int}")]
        [ResponseType(typeof(List<OrderModel>))]
        public HttpResponseMessage GetOrdersInDateRange(int fromDateInt, int toDateInt)
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.InternalServerError);
        }

        [HttpGet]
        [Route("api/Orders/GetOrderDetails/{orderID:int}")]
        [ResponseType(typeof(List<OrderDetailModel>))]
        public HttpResponseMessage GetOrderDetails(int orderID)
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.InternalServerError);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/Order/Calculate/{languageID:int}/{marketID:int}/{regionID:int?}")]
        [ResponseType(typeof(List<OrderDetailModel>))]
        public async Task<HttpResponseMessage> CalculateOrder([FromBody] OrderModel order, int languageID, int marketID, int? regionID = null)
        {
            return await Task.FromResult(Request.CreateResponse(System.Net.HttpStatusCode.InternalServerError));
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/Order/{languageID:int}/{marketID:int}/{regionID:int?}")]
        [ResponseType(typeof(OrderResponseModel))]
        public async Task<HttpResponseMessage> CreateCoachEnrollmentOrder_Old([FromBody] OrderModel order, int languageID, int marketID, int? regionID = null)
        {
            return await Task.FromResult(Request.CreateResponse(System.Net.HttpStatusCode.InternalServerError));
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/Order/RetailEnrollment/{languageID:int}/{marketID:int}/{regionID:int?}")]
        [ResponseType(typeof(OrderResponseModel))]
        public async Task<HttpResponseMessage> CreateRetailEnrollmentOrder([FromBody] OrderModel order, int languageID, int marketID, int? regionID = null)
        {
            return await Task.FromResult(Request.CreateResponse(System.Net.HttpStatusCode.InternalServerError));
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/Order/CoachEnrollment/{languageID:int}/{marketID:int}/{regionID:int?}")]
        [ResponseType(typeof(OrderResponseModel))]
        public async Task<HttpResponseMessage> CreateCoachEnrollmentOrder([FromBody] OrderModel order, int languageID, int marketID, int? regionID = null)
        {
            return await Task.FromResult(Request.CreateResponse(System.Net.HttpStatusCode.InternalServerError));
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/Order/RegistrationRequest/{languageID:int}/{marketID:int}/{regionID:int?}")]
        [ResponseType(typeof(OrderResponseModel))]
        public async Task<HttpResponseMessage> RegistrationRequest([FromBody] OrderModel order, int languageID, int marketID, int? regionID = null)
        {
            return await Task.FromResult(Request.CreateResponse(System.Net.HttpStatusCode.InternalServerError));
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("api/CheckReferer")]
        [ResponseType(typeof(string))]
        public HttpResponseMessage CheckReferer()
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.InternalServerError);
        }
    }
}