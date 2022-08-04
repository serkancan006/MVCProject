using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules_Fluent_Validation
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş Geçemezsiniz");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadını boş Geçemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda Kısmını boş Geçemezsiniz");
            RuleFor(x => x.WriterTittle).NotEmpty().WithMessage("Ünvan Kısmını boş Geçemezsiniz");
            RuleFor(x => x.WriterSurName).MinimumLength(3).WithMessage("Lütfen en az 2 karakter girişi yapın");
            RuleFor(x => x.WriterSurName).MaximumLength(20).WithMessage("Lütfen 50 karakterden fazla giriş yapmayın");
        }
    }
}
