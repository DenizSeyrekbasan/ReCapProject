using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapDbContext>, ICarDal
    {
        //urune ait ozel operasyonlari burada tutucaz
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var result = from p in context.Brands
                             join c in context.Cars
                             on p.Name equals c.DailyPrice
                             select new CarDetailDto
                             {
                                 Id = p.Id,
                                 BrandId = c.BrandId,
                                 DailyPrice = c.DailyPrice                                                                
                             };
                return result.ToList();
            }
        }
    }
}
