namespace BackpackTfApi.Classifieds.UserToken.ListingsCreator.Models
{
    public class Result
    {
        public string Created { get; internal set; }

        public Error Error { get; internal set; }

        public string Retry { get; internal set; }

        public string Used { get; internal set; }

        public string Cap { get; internal set; }
    }
}