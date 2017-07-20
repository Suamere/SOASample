namespace WebFletch.Order.Models.Enums
{
    public enum OrderStatus
    {
        Incomplete = 0,
        Pending = 1,
        CCDeclined = 2,
        ACHDeclined = 3,
        Cancelled = 4,
        CCPending = 5,
        ACHPending = 6,
        Accepted = 7,
        Printed = 8,
        Shipped = 9,
        PendingInventory = 10,
        Testing = 100,
    }
}