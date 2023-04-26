namespace CurrencyDotNet.RestClient.Responses.Abstractions;

public class CallResult<T> : Error
{
    public T? Data { get; internal set; }
    public Error? Error { get; internal set; }
    public bool IsSuccess => Error == null;

    public CallResult(Error? error) => Error = error;
    public CallResult(T? data) => Data = data;
}
