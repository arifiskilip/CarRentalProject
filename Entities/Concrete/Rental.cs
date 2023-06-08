using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Rental : BaseEntity, IEntity
    {
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool IsDelivered { get; set; }
    }
}
