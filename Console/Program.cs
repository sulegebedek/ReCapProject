using Business.Concrete;
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

            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetRentalDetails();

            if (result.Success == true)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine( rental.Id + " / " + rental.FirstName + " / " + rental.LastName + " / " + rental.CompanyName + " / " + rental.RentDate + " / " + rental.ReturnDate);
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
                }
                                  
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            rentalManager.Add(new Rental
            {
                Id = 2,
                CarId = 5,
                CustomerId = 3,
                RentDate = "18.02.2021",
                ReturnDate = "20.02.2021"
            });
            rentalManager.Add(new Rental
            {
                Id = 3,
                CarId = 12,
                CustomerId = 6,
                RentDate = "12.02.2021",
                ReturnDate = "20.02.2021"
            });
            rentalManager.Add(new Rental
            {
                Id = 4,
                CarId = 7,
                CustomerId = 4,
                RentDate = "21.02.2021",
                ReturnDate = "22.02.2021"
            });
            rentalManager.Add(new Rental
            {
                Id = 5,
                CarId = 19,
                CustomerId = 2,
                RentDate = "22.02.2021",
                ReturnDate = "23.02.2021"
            });
            rentalManager.Add(new Rental
            {
                Id = 6,
                CarId = 24,
                CustomerId = 5,
                RentDate = "13.02.2021",
                ReturnDate = "14.02.2021"

            });
            rentalManager.Add(new Rental
            {
                Id = 7,
                CarId = 15,
                CustomerId = 8,
                RentDate = "16.02.2021",
                ReturnDate = "21.02.2021"
            });
            rentalManager.Add(new Rental
            {
                Id = 8,
                CarId = 7,
                CustomerId = 7,
                RentDate = "08.02.2021",
                ReturnDate = "15.02.2021"
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
            UserManager userManager = new UserManager(new EfUserDal());

            userManager.Add(new User { Id = 1, FirstName = "Şule", LastName = "Gebedek", Email = "sulegebedek@gmail.com", Password = "123456" });
            //userManager.Add(new User {Id=2, FirstName = "İrem", LastName = "Demir", Email = "iremdemir@gmail.com", Password = "irem123" });
            //userManager.Add(new User { Id = 3, FirstName = "Hüseyin", LastName = "Keleş", Email = "huseyinkeles@gmail.com", Password = "hk123" });
            //userManager.Add(new User { Id = 4, FirstName = "Tarık", LastName = "Yılmaz", Email = "tarikyilmaz@gmail.com", Password = "tarık123" });
            //userManager.Add(new User { Id = 5, FirstName = "Ceyhun", LastName = "Taşdemir", Email = "ceyhuntaşdemir@gmail.com", Password = "cey123" });
            //userManager.Add(new User { Id = 6, FirstName = "Feyza", LastName = "Güçlü", Email = "feyzaguclu@gmail.com", Password = "guclu123" });
            //userManager.Add(new User { Id = 7, FirstName = "Fırat", LastName = "Şengül", Email = "firatsengul@gmail.com", Password = "fs123" });
            //userManager.Add(new User { Id = 8, FirstName = "Gizem", LastName = "Sayar", Email = "gizemsayar@gmail.com", Password = "gizem123" });


            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName + " " + user.LastName);

            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + "  / " + car.BrandName + " / " + car.ColorName + "  / " + car.DailyPrice + "TL   ");
                    Console.WriteLine("-------------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
