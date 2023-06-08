using Core.Entities;

namespace Entities.Concrete
{
    public class Brand : BaseEntity, IEntity
    {
        public string Name { get; set; }
    }
}
