using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class CreditCard : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CardNumber { get; set; }
        public DateTime DateMonth { get; set; }
        public DateTime DateYear{ get; set; }
        public string NameOnTheCard { get; set; }
        public int Cvv { get; set; }
    }
}
