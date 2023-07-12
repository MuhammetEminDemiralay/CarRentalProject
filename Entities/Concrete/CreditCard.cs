using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class CreditCard : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public long CardNumber { get; set; }
        public int DateMonth { get; set; }
        public int DateYear { get; set; }
        public string NameOnTheCard { get; set; }
        public string Cvv { get; set; }
    }
}
