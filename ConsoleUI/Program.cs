using Business.Concrete;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental { 
            CarId = 2,
            CustomerId = 2,
            RentDate = "12.05.2023"
            });
            

            Console.Read();
        }
    }
}


