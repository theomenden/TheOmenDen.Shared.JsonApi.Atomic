using System.Collections;
using TheOmenDen.Shared.JsonApi.Models.Metas;
using TheOmenDen.Shared.JsonApi.ViewModels;

namespace TheOmenDen.Shared.JsonApi.Atomic;

/// <summary>
/// A collection of Atomic Operations
/// </summary>
public sealed class AtomicCollection : ViewModelCollection<IAtomic>
{
    public AtomicCollection(string selfUrl) : base(selfUrl)
    {
    }

    public AtomicCollection(string selfUrl, ICollection<ViewModel<IAtomic>> data) : base(selfUrl, data)
    {
    }
}