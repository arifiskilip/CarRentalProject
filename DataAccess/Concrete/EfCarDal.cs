using Core.DataAccess;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace DataAccess.Concrete
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetail> FetchCarDetailByBrandId(int id)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var carDetail = from c in context.Cars
                                join b in context.Brands on
                                c.BrandId equals b.Id
                                join co in context.Colors on
                                c.ColorId equals co.Id
                                where b.Id == id
                                select new CarDetail
                                {
                                    BrandName = b.Name,
                                    CarName = c.Description,
                                    ColorName = co.Name,
                                    DailyPrice = c.DailyPrice
                                   
                                };
                return carDetail.ToList();
            }
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Cars.Where(x => x.BrandId == brandId).ToList();  
            }
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Cars.Where(x => x.ColorId == colorId).ToList();
            }
        }

        public List<CarDetail> GetCarsDetail()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var carDetail = from c in context.Cars
                                join b in context.Brands on
                                c.BrandId equals b.Id
                                join co in context.Colors on
                                c.ColorId equals co.Id
                                select new CarDetail
                                {
                                    BrandName = b.Name,
                                    CarName = c.Description,
                                    ColorName = co.Name,
                                    DailyPrice = c.DailyPrice
                                };
                return carDetail.ToList();
            }
        }
    }
}
