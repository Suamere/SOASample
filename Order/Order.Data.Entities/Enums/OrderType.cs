namespace WebFletch.Order.Data.Entities.Enums
{
    public enum OrderType
    {
        CustomerService = 1,
        ShoppingCart = 2,
        WebWizard = 3,
        RecurringOrder = 4,
        Import = 5,
        BackOrder = 6,
        ReplacementOrder = 7,
        ReturnOrder = 8,
        WebRecurringOrder = 9,
        TicketSystem = 10,
        APIOrder = 11,
        BackOrderParentNoShip = 12,
        ChildOrder = 13,
    }
}