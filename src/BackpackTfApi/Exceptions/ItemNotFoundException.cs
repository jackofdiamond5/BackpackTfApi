using System;

namespace BackpackTfApi.Exceptions
{
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException(string message)
            : base(message) { }
    }
}
