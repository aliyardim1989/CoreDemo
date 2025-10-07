using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Boş geçilemez.") ;
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen 50 karakterden Fazla Veri Girişi yapmayın..");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen En az 2 karakter girşi yapın.");
            RuleFor(x=>x.WriterMail).NotEmpty().WithMessage("Mail Adresi Boş geçilemez..");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre Boş geçilemez..");
        }
    }

}
