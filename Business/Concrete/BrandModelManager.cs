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
        public IResult Add(BrandModel brandModel)
        {
            _brandModelDal.Add(brandModel);
            return new SuccessResult();
        }

        public IResult Delete(BrandModel brandModel)
        {
            _brandModelDal.Delete(brandModel);
            return new SuccessResult();
        }

        public IDataResult<List<BrandModel>> GetAll()
        {
            return new SuccessDataResult<List<BrandModel>>(_brandModelDal.GetAll());
        }

        public IDataResult<BrandModel> GetBrandModelById(int brandModelId)
        {
            return new SuccessDataResult<BrandModel>(_brandModelDal.Get(p => p.Id == brandModelId));
        }

        public IDataResult<List<BrandModel>> GetBrandModelsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<BrandModel>>(_brandModelDal.GetAll(p => p.BrandId == brandId), "Get brand models by brand ıd");
        }

        public IResult Update(BrandModel brandModel)
        {
            _brandModelDal.Update(brandModel);
            return new SuccessResult();
        }
    }
}
