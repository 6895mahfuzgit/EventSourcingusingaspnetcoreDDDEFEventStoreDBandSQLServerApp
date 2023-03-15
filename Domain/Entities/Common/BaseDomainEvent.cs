namespace Domain.Entities.Common
{
    public class BaseDomainEvent<TA, TKey> : IDomainEvent<TKey> where TA : IAggregateRoot<TKey>
    {

        protected BaseDomainEvent()
        {

        }

        protected BaseDomainEvent(TA aggregateRoot)
        {
            if (aggregateRoot is null)
            {
                throw new ArgumentNullException(nameof(aggregateRoot));
            }

            AggregateId = aggregateRoot.Id;
            AggregateVersion = aggregateRoot.Version;
            TimeStamp = DateTime.UtcNow;
        }

        public long AggregateVersion { get; protected set; }
        public TKey AggregateId { get; protected set; }
        public DateTime TimeStamp { get; protected set; }
    }
}
