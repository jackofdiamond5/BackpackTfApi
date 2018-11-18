namespace BackpackTfApi.Static
{
    public static class Messages
    {
        public const string ItemNotFoundErrorMessage = "The specified item was not found.";

        public const string DeserializeCurrencyErrorMessage = "Cannot unmarshal type Currency.";

        public const string SerializeCurrencyErrorMessage = "Cannot marshal type Currency.";

        public const string CraftableUnionDeserializeErrorMessage = "Cannot unmarshal type CraftableUnion.";

        public const string CraftableUnionSerializeErrorMessage = "Cannot marshal type CraftableUnion.";

        public const string CurrencyNotFoundError = "Cannot resolve currency name.";

        public const string ResponseNullError = "Cannot resolve \"response\" argument.";
    }
}
