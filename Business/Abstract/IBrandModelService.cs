using Core.Utilites.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandModelService
    {
        IDataResult<List<CarModel>> GetAll();
        IDataResult<List<CarModel>> GetByBrandId(int brandId);
        IResult Add(CarModel brandModel);
        IResult Update(CarModel brandModel);
        IResult Delete(CarModel brandModel);
    }
}
