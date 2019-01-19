namespace BackpackTfApi.Static
{
    public static class Messages
    {
        public const string ItemNotFoundError = "The specified item was not found.";

        public const string DeserializeCurrencyError = "Cannot unmarshal type Currency.";

        public const string SerializeCurrencyError = "Cannot marshal type Currency.";

        public const string CraftableUnionDeserializeErroe = "Cannot unmarshal type CraftableUnion.";

        public const string CraftableUnionSerializeError = "Cannot marshal type CraftableUnion.";

        public const string CurrencyNotFoundError = "Cannot resolve currency name.";

        public const string ResponseNullError = "Cannot resolve \"response\" argument.";

        public const string InventoryNullError = "The user's inventory cannot be null.";

        public const string ItemQualityError = "Failed to determine item quality.";
    }
}
