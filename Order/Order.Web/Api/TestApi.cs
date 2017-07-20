using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace WebFletch.Order.Web.Api
{
    public class TestApiController : ApiController
    {
        private Core.ITestOrders _iTestService;

        public TestApiController(Core.ITestOrders iTestService)
        {
            _iTestService = iTestService;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/Success")]
        public HttpResponseMessage TestSuccess()
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, "Success");
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/Fail")]
        public HttpResponseMessage TestFailure()
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.InternalServerError);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/Exception")]
        public HttpResponseMessage TestException()
        {
            throw new System.Exception("Successful Exception Test");
        }

        [HttpGet]
        [Route("api/Test")]
        [ResponseType(typeof(List<Models.TestModel>))]
        public HttpResponseMessage GetTests()
        {
            var tests = _iTestService.GetTestRecords();
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, tests);
        }

        [HttpPost]
        [Route("api/Test")]
        public HttpResponseMessage AddTest([FromBody] Models.TestModel test)
        {
            _iTestService.AddTestRecord(test);
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, "Successfully Added: " + test.TestDescription);
        }
    }
}