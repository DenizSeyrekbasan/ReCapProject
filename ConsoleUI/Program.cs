using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //carTest();
            //brandTest();
            //colorTest();
            //Data Transformation Object : tasinacak objeler


            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager= new BrandManager(new EfBrandDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine( car.BrandId+ "  / " + "  Günlük Kiralık Fiyatı : " +
                car.DailyPrice+ "  / " + "  Model Yılı :  : " + car.ModelYear + " / ");
            }

            


            Console.Read();
        }

        private static void colorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void brandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void carTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.DailyPrice + "/" + car.ModelYear);
            }
        }
    }
}