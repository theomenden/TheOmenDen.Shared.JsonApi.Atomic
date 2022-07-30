namespace TheOmenDen.Shared.JsonApi.Atomic.Interfaces;

/// <summary>
/// Marker interface for compliance to be a Reference for JsonApi Atomic Standard
/// </summary>
public interface IRef
{
    /// <summary>
    /// The Identification information
    /// </summary>
    EntityId Id { get; }

    /// <summary>
    /// The reference type
    /// </summary>
    Type Type { get; }

    /// <summary>
    /// Any relationship that we want to define for a particular <see cref="OperationTypes"/>
    /// </summary>
    Relationship Relationship { get; }
}

/// <summary>
/// <inheritdoc cref="IRef"/>
/// </summary>
/// <typeparam name="T">The underlying type that we're referencing</typeparam>
public interface IRef<T>: IRef
{
}
