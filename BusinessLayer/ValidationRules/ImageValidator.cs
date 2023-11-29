using EntitiyLayer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık kısmını boş geçemezsiniz");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("20 karakterden fazla veri girişi yapılamaz");
            RuleFor(x => x.Title).MinimumLength(8).WithMessage("8 karakterden az veri girişi yapılamaz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Yolunu boş geçemezsiniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Açıklama max. 50 karakter olmalı!");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("Açıklama min. 20 karakter olmalı!");
        }
    }
}
