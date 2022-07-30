using TheOmenDen.Shared.JsonApi.Models.Metas;

namespace TheOmenDen.Shared.JsonApi.Atomic.Interfaces;
/// <summary>
/// Marker interface for any <see cref="OperationTypes"/> that don't require any return values
/// </summary>
/// <remarks>Endpoints that return this MUST return a result of <see cref="System.Net.HttpStatusCode.NoContent"/></remarks>
public interface IAtomicResult
{
}

/// <summary>
/// Marker interface for any <see cref="OperationTypes"/> that require return values
/// </summary>
/// <typeparam name="T">The underlying resulting type</typeparam>
/// /// <remarks>
/// <para>Endpoints that return this MUST return a result of <see cref="System.Net.HttpStatusCode.NoContent"/>, or</para>
/// <para>Or can return <seealso cref="System.Net.HttpStatusCode.OK"/></para>
/// </remarks>
public interface IAtomicResult<T>: IAtomicResult    
{
    /// <summary>
    /// The results of the operation
    /// </summary>
    Data<T> Result { get; set; }

    /// <summary>
    /// The meta data involved in the operation
    /// </summary>
    Meta Meta { get; }
}
