namespace Domain.Entities.Common
{

    public interface IDomainEvent<out TKey>
    {
        long AggregateVersion { get; }
        TKey AggregateId { get; }
        DateTime TimeStamp { get; }
    }
}
