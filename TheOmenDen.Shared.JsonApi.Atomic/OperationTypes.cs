namespace TheOmenDen.Shared.JsonApi.Atomic;
/// <summary>
/// Represents the operations that can take place in an Atomic standard
/// </summary>
public enum OperationTypes
{
    /// <value>
    /// Represents an Adding operation
    /// </value>
    Add,
    /// <value>
    /// Represents an Updating Operation
    /// </value>
    Update,
    /// <value>
    /// Represents a Removal Operation
    /// </value>
    Remove,
}