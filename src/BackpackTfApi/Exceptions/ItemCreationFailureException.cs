using System;

namespace BackpackTfApi.Exceptions
{
    public class ItemCreationFailureException : Exception
    {
        public ItemCreationFailureException(string message)
            : base(message) { }
    }
}
