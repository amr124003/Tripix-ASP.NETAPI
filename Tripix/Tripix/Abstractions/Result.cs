namespace Tripix.Abstractions
{
    public class Result 
    {
        public Result (bool isSuccess , Error error)
        {
            if ((!isSuccess && error == Error.None) || (isSuccess && error != Error.None))
            {
                throw new InvalidOperationException();
            }
            IsSuccess = isSuccess;
            Error = error;
        }
        public bool IsSuccess { get; }
        public Error Error { get; } = Error.None;
        public bool IsFalure => !IsSuccess;
        public static Result Success () => new(true, Error.None);
        public static Result Failure(Error error) => new(false, error);
        public static Result<T> Success<T> (T value) => new(value , true, Error.None);
        public static Result<T> Failure<T> (Error error ) => new(default , false, error);
    }

    public class Result<T> : Result
    {
        private readonly T? value;

        public Result(T? value  , bool isSuccess , Error error):base(isSuccess,error)
        {
            this.value = value;
        }

        public T Value => IsSuccess ? value : throw new InvalidOperationException("No Value For Result");
    }
}
