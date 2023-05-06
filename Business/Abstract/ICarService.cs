using Core.Entities;
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
        List<Car> GetAll(); //tum araclari listeleyen ortam
        List<CarDetailDto> GetCarDetails();
        
        
    }
}
