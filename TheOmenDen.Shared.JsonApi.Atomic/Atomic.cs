using TheOmenDen.Shared.JsonApi.Atomic.Resources;

namespace TheOmenDen.Shared.JsonApi.Atomic;

#nullable disable
public sealed class Atomic<T> : IAtomic<T>
{
    private string _href;

    private IRef _ref;

    private Data<T> _data;

    public Atomic(OperationTypes operationType, Data<T> data)
    {
        OperationType = operationType;
        _data = data;
    }

    public OperationTypes OperationType { get; }

    public string Href
    {
        get => _href;
        set => SetHref(value);
    }

    public IRef Ref
    {
        get => _ref;
        set => SetRef(value);
    }

    public Data<T> Data => _data;

    #region Ensuring Methods
    private void EnsureHrefHasNotBeenSet()
    {
        if (!String.IsNullOrWhiteSpace(Href))
        {
            throw new InvalidOperationException(Resource.CannotAddRefIfHrefisSet);
        }
    }

    private void EnsureRefHasNotBeenSet()
    {
        if (Ref is not null)
        {
            throw new InvalidOperationException(Resource.CannotAddHrefifRefIsSet);
        }
    }

    private void SetHref(String value)
    {
        EnsureRefHasNotBeenSet();

        _href = value;
    }

    private void SetRef(IRef value)
    {
        EnsureHrefHasNotBeenSet();

        _ref = value;
    }
    #endregion
}

