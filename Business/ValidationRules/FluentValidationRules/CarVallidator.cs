using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidationRules
{
    public class CarVallidator : AbstractValidator<Car>
    {
        public CarVallidator()
        {
            RuleFor(p => p.DailyPrice).GreaterThan(200);
        }
    }
}
