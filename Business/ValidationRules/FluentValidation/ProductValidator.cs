﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //kurallar buraya

            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);

            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);

            //RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürün adı 'A' harfi ile başlamalıdır.");

        }


        private bool StartWithA(string arg)
        {
            //Ürün adı 'A' harfi ile başlamalıdır.
            return arg.StartsWith("A");
        }
    }
}
