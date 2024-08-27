using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı boş geçilemez");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadı boş geçilemez");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Yazar ünvanı boş geçilemez");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("Yazar soyadı 2 karakterden küçük olamaz");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Yazar soyadı 2 karakterden küçük olamaz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmı boş geçilemez"); 
        }

    }
}