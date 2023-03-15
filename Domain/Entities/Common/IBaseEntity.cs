namespace Domain.Entities.Common
{
    /// <summary>
    /// Interface for Base Entity
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    public interface IBaseEntity<out TKey>
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        TKey Id { get; }
    }
}
