namespace WebFletch.Order.Data.Entities
{
    public class RecurringOrderFrequencyEntity
    {
        public int FrequencyID { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
    }
}