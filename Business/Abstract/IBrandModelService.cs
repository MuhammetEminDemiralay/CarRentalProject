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
        IDataResult<List<BrandModel>> GetAll();
        IDataResult<BrandModel> GetBrandModelById(int brandModelId);
        IDataResult<List<BrandModel>> GetBrandModelsByBrandId(int brandId);
        IResult Add(BrandModel brandModel);
        IResult Update(BrandModel brandModel);
        IResult Delete(BrandModel brandModel);
     
    }
}
