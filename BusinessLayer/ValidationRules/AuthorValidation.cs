using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AuthorValidation : AbstractValidator<Author>
    {
        public AuthorValidation()
        {
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Ad Soyad kısmı boş geçilemez!");
            RuleFor(x => x.AuthorName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız!");
            RuleFor(x => x.AuthorName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız!");
            RuleFor(x => x.AuthorMail).NotEmpty().WithMessage("Mail adresi boş geçilemez!");
            RuleFor(x => x.AuthorMail).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi girişi yapınız!");
            RuleFor(x => x.CountryID).NotEqual(0).WithMessage("Ülke alanı boş geçilemez!");
            RuleFor(x => x.AuthorPassword).NotEmpty().WithMessage("Şifre alanı boş geçilemez!")
                .Matches(@"[A-Z]+").WithMessage("Şifreniz en az 1 büyük harf içermelidir!")
                .Matches(@"[a-z]+").WithMessage("Şifreniz en az 1 küçük harf içermelidir!.")
                .Matches(@"[0-9]+").WithMessage("Şifreniz en az 1 rakam içermelidir!");
            RuleFor(x => x.AuthortImage).NotEmpty().WithMessage("Görsel dizini alanı boş geçilemez!");

        }
    }
}
