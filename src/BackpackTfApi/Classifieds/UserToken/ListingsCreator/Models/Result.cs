namespace BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models
{
    public class Result
    {
        public int? Created { get; internal set; }

        public Error? Error { get; internal set; }

        public long? Retry { get; internal set; }

        public int? Used { get; internal set; }

        public int? Cap { get; internal set; }
    }
}