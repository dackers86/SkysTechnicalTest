using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SkyTechnicalTest.Domain;

namespace SkyTechnicalTest.Validation
{
    public class BillValidator : AbstractValidator<Bill>
    {
        public BillValidator()
        {
            RuleFor(b => b).NotNull();
        }
    }
}
