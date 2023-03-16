using Domain.Entities.Common;

namespace Domain.Entities.Events.CatalogItem
{
    public class CatalogItemDeleted : BaseDomainEvent<Entities.CatalogItem, Guid>
    {
        private CatalogItemDeleted()
        {

        }
        public CatalogItemDeleted(Entities.CatalogItem catalogItem) : base(catalogItem)
        {
            IsDeleted = catalogItem.IsDeleted;
        }
        public bool IsDeleted { get; private set; }
    }
}
