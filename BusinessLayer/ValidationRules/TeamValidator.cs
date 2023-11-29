using EntitiyLayer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Personel ismini boş geçemezsiniz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev kısmını boş geçemezsiniz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Yolu boş geçemezsiniz");
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("İsim boş geçemezsiniz");
            RuleFor(x => x.PersonName).MaximumLength(20).WithMessage("50 karakterden fazla veri girişi yapılamaz");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("50 karakterden fazla veri girişi yapılamaz");
           

        }
    }
}
