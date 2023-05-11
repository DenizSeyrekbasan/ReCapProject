using Core.Entities;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll(); //tum araclari listele
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<Car> GetById(int Id);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        
        
    }
}
