using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.CarId).NotEmpty();
            RuleFor(c => c.CarId).GreaterThan(0);
            RuleFor(r => r.CustomerId).NotEmpty();
            RuleFor(c => c.CustomerId).GreaterThan(0);
            RuleFor(r => r.StartDateRent).NotEmpty();
            RuleFor(rental => rental.StartDateRent).LessThan(rental => rental.ReturnDate);

            RuleFor(r => r.ReturnDate).GreaterThanOrEqualTo(r => r.StartDateRent).WithMessage("Aracın teslim tarihi kiralama tarihinden önce olamaz.");

        }
    }
}
