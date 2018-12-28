using System;

namespace BackpackTfApi.Exceptions
{
    public class InventoryNullException : Exception
    {
        public InventoryNullException(string message)
            : base(message) { }
    }
}
