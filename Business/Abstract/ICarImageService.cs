using Core.Utilites.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {

        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetImagesByCarId(int carId);
        IResult Add(IFormFile file, CarImage carImage);
        IResult AddCollective(IFormFile[] files, CarImage carImage);
        IResult Update(IFormFile file, CarImage carImage);
        IResult Delete(CarImage carImage);

    }
}
