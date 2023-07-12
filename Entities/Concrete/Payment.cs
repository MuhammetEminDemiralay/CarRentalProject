using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Payment : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CreditCardId { get; set; }
        public int TotalAmount { get; set; }
    }
}
