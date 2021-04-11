using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //UserTest();
            //CustomerTest();
            //RentalTest();


        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            rentalManager.Add(new Rental
            {
                
                Id = 2,
                CarId = 5,
                CustomerId = 3,
                StartDateRent = DateTime.Now,
                ReturnDate = null
            });
            rentalManager.Add(new Rental
            {
                Id = 3,
                CarId = 12,
                CustomerId = 6,
                StartDateRent = DateTime.Now,
                ReturnDate = null
            });
            
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            customerManager.Add(new Customer { Id = 1, CompanyName = "Microsoft" });
            customerManager.Add(new Customer { Id = 2, CompanyName = "Huawei" });
            customerManager.Add(new Customer { Id = 3, CompanyName = "Google" });
            customerManager.Add(new Customer { Id = 4, CompanyName = "Amazon" });
            customerManager.Add(new Customer { Id = 5, CompanyName = "Turk Telekom" });
            customerManager.Add(new Customer { Id = 6, CompanyName = "Yurtici Kargo" });
            customerManager.Add(new Customer { Id = 7, CompanyName = "THY" });
            customerManager.Add(new Customer { Id = 8, CompanyName = "Turkcell" });
        }

        private static void UserTest()
        {
            var userManager = new UserManager(new EfUserDal());

            //User user = new User 
            //{ 
            //    Id=1,
            //    FirstName = "Şule", 
            //    LastName = "Gebedek", 
            //    Email = "sulegebedek@gmail.com", 
            //    Password = "123456" 
            //};
            

            //Console.WriteLine(user.FirstName + " " + user.LastName);

         
        }

        private static void CarTest()
        {
            //CarManager carManager = new CarManager(new EfCarDal());

            //var result = carManager.GetCarDetails();

            //if (result.Success == true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.CarId + "  / " + car.BrandName + " / " + car.ColorName + "  / " + car.DailyPrice + "TL   ");
            //        Console.WriteLine("-------------------------------------------------------------");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
        }
    }
}
