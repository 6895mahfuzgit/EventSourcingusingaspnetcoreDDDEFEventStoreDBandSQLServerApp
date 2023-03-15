namespace Domain.Entities.Common
{
    public abstract class BaseEntity<TKey> : IBaseEntity<TKey>
    {

        protected BaseEntity()
        {

        }

        protected BaseEntity(TKey id)
        {
            Id = id;
        }



        public TKey Id { get; protected set; }
    }
}
