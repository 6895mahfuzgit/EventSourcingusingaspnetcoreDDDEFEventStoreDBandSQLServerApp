namespace Domain.Entities.Common
{
    public interface IAggregateRoot<out TKey>:IBaseEntity<TKey>
    {
        long Version { get; }
        IReadOnlyCollection<IDomainEvent<TKey>> Events { get; }
        void ClearEvents();
    }
}
