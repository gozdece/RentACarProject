using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarDetailTest();

            //RentalDetailTest();

        }

        private static void RentalDetailTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var item in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine("Kiralanan arabalar:");
                Console.WriteLine(item.CarId + " " + item.CustomerId + " " + item.RentalId + " " + item.RentDate + " " + item.ReturnDate);
            }
        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(item.CarId + " " + item.BrandName + " " + item.ColorName + " " + item.DailyPrice);
            }
        }
    }
}
