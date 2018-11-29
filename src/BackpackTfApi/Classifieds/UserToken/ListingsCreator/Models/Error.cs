namespace BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models
{
    public enum Error
    {
        OK = 0,
        ItemNotInInventory = 1,
        InvalidItem = 2,
        ItemNotListable = 3,
        ItemNotTradable = 4,
        MarketplaceItemNotPriced = 5,
        RelistTimeout = 6,
        ListingCapExceeded = 7,
        CurrenciesNotSpecified = 8,
        CyclicCurrency = 9,
        PriceNotSpecified = 10,
        UnknownIntent = 11
    }
}
