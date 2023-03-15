namespace Domain.Entities.Common
{

    public interface IDomainEvent<out TKey>
    {
        public long AggregateVersion { get; }
        TKey AggregateId { get; }
        DateTime TimeStamp { get; }
    }
}
