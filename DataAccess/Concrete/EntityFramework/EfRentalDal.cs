using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental,CarDatabaseContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars 
                             on r.CarId equals c.Id
                             join b in context.Brands 
                             on c.BrandId equals b.BrandId
                             join co in context.Colors 
                             on c.ColorId equals co.ColorId
                             join cu in context.Customers 
                             on r.CustomerId equals cu.Id
                             join u in context.Users 
                             on cu.UserId equals u.Id

                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 CarId = c.Id,
                                 CustomerId = cu.Id,
                                 CarName = c.CarName,
                                 Description = c.Description,
                                 ReturnDate = r.ReturnDate,
                                 StartDateRent = r.StartDateRent,
                                 DailyPrice = c.DailyPrice,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 CompanyName = cu.CompanyName,
                                 UserName = u.FirstName + " " + u.LastName,
                             };

                return result.ToList();
            }
        }
    }
}
