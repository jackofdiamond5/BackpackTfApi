using System;

namespace BackpackTfApi.Exceptions
{
    public class ClassifiedCreationFailureException : Exception
    {
        public ClassifiedCreationFailureException(string message)
            : base(message) { }
    }
}
