using Business.Abstract;
using Business.Constants;
using Core.Utilites;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {

        private ICarImageDal _imageDal;

        public CarImageManager(ICarImageDal imageDal)
        {
            _imageDal = imageDal;
        }





        public IResult Add(IFormFile file, CarImage carImage)
        {
            carImage.ImagePath = FileHelper.Add(file);
            carImage.Date = DateTime.Now;
            _imageDal.Add(carImage);
            return new SuccessResult("Car image added");
        }

        public IResult AddCollective(IFormFile[] files, CarImage carImage)
        {
            foreach (var file in files)
            {
                carImage = new CarImage { CarId = carImage.CarId };
                Add(file, carImage);
            }
            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            _imageDal.Delete(carImage);
            return new SuccessResult(Messages.İmageDelete);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_imageDal.GetAll(), "RESİMLER lİSTELENDİ");
        }

        public IDataResult<CarImage> GetImagesByCarId(int carId)
        {
            return new SuccessDataResult<CarImage>(_imageDal.Get(p => p.Id == carId), Messages.GetİmagesByCarId);
        }


        public IResult Update(IFormFile file, CarImage carImage)
        {
            throw new NotImplementedException();
        }
    }
}
