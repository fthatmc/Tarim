using EntitiyLayer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Açıklama1 Boş Geçilemez");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Açıklama2 Boş Geçilemez");
            RuleFor(x => x.Description3).NotEmpty().WithMessage("Açıklama3 Boş Geçilemez");
            RuleFor(x => x.Description4).NotEmpty().WithMessage("Açıklama4 Boş Geçilemez");
            RuleFor(x => x.Mapinfo).NotEmpty().WithMessage("Harita Bilgisi Boş Geçilemez");
            RuleFor(x => x.Description1).MaximumLength(55).WithMessage("55 karaktarden fazla olamaz");
            RuleFor(x => x.Description2).MaximumLength(25).WithMessage("25 karaktarden fazla olamaz");
            RuleFor(x => x.Description3).MaximumLength(25).WithMessage("25 karaktarden fazla olamaz");
            RuleFor(x => x.Description4).MaximumLength(25).WithMessage("25 karaktarden fazla olamaz");
        }
    }
}
