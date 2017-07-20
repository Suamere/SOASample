using Suamere.Utilities.EndpointConnection.Contracts;
using Suamere.Utilities.Monad;

namespace WebFletch.Order.SDK.Implementation
{
    public class TestService : Core.ITest
    {
        private IEndpointConnection _endpoint;

        public TestService(IEndpointConnection endpoint)
        {
            _endpoint = endpoint;
        }

        public Maybe<string> TestSuccessEndpoint()
        {
            try { return _endpoint.Get<string>("api/Success").ToMaybe(); }
            catch (System.Net.WebException ex) { return Maybe.Empty<string>(ex); }
        }
        public Maybe<string> TestFailEndpoint()
        {
            try { return _endpoint.Get<string>("api/Fail").ToMaybe(); }
            catch (System.Net.WebException ex) { return Maybe.Empty<string>(ex); }
        }
        public Maybe<string> TestExceptionEndpoint()
        {
            try { return _endpoint.Get<string>("api/Exception").ToMaybe(); }
            catch (System.Net.WebException ex) { return Maybe.Empty<string>(ex); }
        }
    }
}