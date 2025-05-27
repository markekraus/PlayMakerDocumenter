#nullable enable

namespace PlayMakerDocumenter
{
    public class Result<T, TError>
    {
        public bool IsSuccess { get; }
        public T? Value { get; }
        public TError? Error { get; }

        private Result(bool IsSuccess, T? Value, TError? Error) =>
            (this.IsSuccess, this.Value, this.Error) = (IsSuccess, Value, Error);

        public static Result<T, TError> Success(T Value) =>
            new Result<T, TError>(true, Value, default);

        public static Result<T, TError> Failure(TError Error) =>
            new Result<T, TError>(false, default, Error);
    }
}
