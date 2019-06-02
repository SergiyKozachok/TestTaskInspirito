namespace TestTask.BusinessLogic.Models
{
    public class RequestResult
    {
        public bool Success { get; set; }

        public string Message { get; set; }
    }

    public class RequestResult<T> : RequestResult
    {
        public T Result { get; set; }
    }
}
