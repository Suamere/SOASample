using Suamere.Utilities.Monad;

namespace WebFletch.Order.SDK.Core
{
    public interface ITest
    {
        Maybe<string> TestSuccessEndpoint();
        Maybe<string> TestFailEndpoint();
        Maybe<string> TestExceptionEndpoint();
    }
}
