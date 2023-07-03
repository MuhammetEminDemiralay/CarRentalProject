using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailDto : IDTO
    {
        public int Id { get; set; }
        public int ColorId { get; set; }
        public int BrandId { get; set; }
        public int CarModelId { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public string BrandDescription { get; set; }
        public string CompanyName { get; set; }
        public string ColorName { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
        public List<string> ImagePath { get; set; }

    }
}
