using Core.DataAccess.Concrete.EntitiyFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : EFEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {

        public List<CarDetailDto> GetCarDetail(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandId equals brand.Id
                             join color in context.Colors
                             on car.ColorId equals color.Id
                             join model in context.BrandModels
                             on car.BrandModelId equals model.Id




                             select new CarDetailDto
                             {
                                 Id = car.Id,
                                 ColorId = color.Id,
                                 BrandId = brand.Id,
                                 BrandModelId = model.Id,
                                 BrandName = brand.BrandName,
                                 Model = model.Model,
                                 BrandDescription = model.BrandDescription,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear,
                                 ImagePath = (from img in context.CarImages where img.CarId == car.Id select img.ImagePath).ToList(),
                                 IsRentable = !context.Rentals.Any(r => r.CarId == car.Id) || !context.Rentals.Any(r => r.CarId == car.Id && (r.ReturnDate > DateTime.Now))
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }


    }
}
