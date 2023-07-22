﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Validation
{
    public class ValidationTool
    {
        public static void Validate(IValidator validator, Object entity)
        {
            var context = new ValidationContext<Object>(entity);
            var validate = validator.Validate(context);

            if (!validate.IsValid)
            {
                throw new ValidationException(validate.Errors);
            }
        }
    }
}
