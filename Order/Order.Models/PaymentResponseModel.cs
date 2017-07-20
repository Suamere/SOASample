namespace WebFletch.Order.Models
{
    public class PaymentResponseModel
    {
        public bool Success { get; set; }
        public int PaymentStatusID { get; set; }
        public string RedirectURL { get; set; }
        public string ExceptionMessage { get; set; }
    }
}