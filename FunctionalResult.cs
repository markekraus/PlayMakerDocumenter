using System;

namespace PlayMakerDocumenter
{
    public static class FunctionalResult
    {
        public static Result<T2, TError> Map<T1, T2, TError>(
            this Result<T1, TError> result, Func<T1, T2> map) =>
            result.IsSuccess
            ? Result<T2, TError>.Success(map(result.Value))
            : Result<T2, TError>.Failure(result.Error);

        public static Result<T, TNewError> MapError<T, TError, TNewError>(
            this Result<T, TError> result, Func<TError, TNewError> map) =>
            result.IsSuccess
            ? Result<T, TNewError>.Success(result.Value)
            : Result<T, TNewError>.Failure(map(result.Error));

        public static TResult Match<T, TError, TResult>(
            this Result<T, TError> result, Func<T, TResult> mapValue, Func<TError, TResult> mapError) =>
            result.IsSuccess
            ? mapValue(result.Value)
            : mapError(result.Error);

        public static Result<T2, TError> Bind<T1, T2, TError>(
            this Result<T1, TError> result, Func<T1, Result<T2, TError>> bind) =>
            result.IsSuccess
            ? bind(result.Value)
            : Result<T2, TError>.Failure(result.Error);
    }
}