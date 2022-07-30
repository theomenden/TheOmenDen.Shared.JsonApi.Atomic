namespace TheOmenDen.Shared.JsonApi.Atomic.Interfaces;
/// <summary>
/// Marks an atomic operation for a <see cref="Models.JsonApi"/> implementation
/// </summary>
public interface IAtomic
{
    /// <summary>
    /// The type of operation
    /// </summary>
    [JsonPropertyName("op")]
    OperationTypes OperationType { get; }

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("href")] 
    String Href { get; }

    /// <summary>
    /// <inheritdoc cref="IRef"/>
    /// </summary>
    [JsonPropertyName("ref")]
    IRef Ref { get; }
}

/// <summary>
/// <inheritdoc cref="IAtomic"/> - over a specified <typeparamref name="T"/>
/// </summary>
/// <typeparam name="T">The type that the atomic operation will occur under</typeparam>
public interface IAtomic<T>: IAtomic
{
    /// <summary>
    /// The data that is contained in the operation
    /// </summary>
    [JsonPropertyName("data")]
    Data<T> Data { get; }
}
