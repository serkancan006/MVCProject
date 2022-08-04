using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules_Fluent_Validation
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adını boş Geçemezsiniz");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın");
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adresini boş Geçemezsiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Kısmını boş Geçemezsiniz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın");
            RuleFor(x => x.Subject).MaximumLength(20).WithMessage("Lütfen 50 karakterden fazla giriş yapmayın");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj Kısmını boş Geçemezsiniz");
           
        }

    }
}
