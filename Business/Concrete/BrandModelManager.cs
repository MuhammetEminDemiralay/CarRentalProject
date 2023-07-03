using Business.Abstract;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandModelManager : IBrandModelService
    {
        IBrandModelDal _brandModelDal;
        public BrandModelManager(IBrandModelDal brandModelDal)
        {
            _brandModelDal = brandModelDal;
        }
        public IResult Add(CarModel brandModel)
        {
            _brandModelDal.Add(brandModel);
            return new SuccessResult();
        }

        public IResult Delete(CarModel brandModel)
        {
            _brandModelDal.Delete(brandModel);
            return new SuccessResult();
        }

     

        public IDataResult<List<CarModel>> GetAll()
        {
            return new SuccessDataResult<List<CarModel>>(_brandModelDal.GetAll());
        }

        public IDataResult<List<CarModel>> GetByBrandId(int brandId)
        {
            return new SuccessDataResult<List<CarModel>>(_brandModelDal.GetAll(p => p.BrandId == brandId));
        }

        public IResult Update(CarModel brandModel)
        {
            _brandModelDal.Update(brandModel);
            return new SuccessResult();
        }
    }
}
