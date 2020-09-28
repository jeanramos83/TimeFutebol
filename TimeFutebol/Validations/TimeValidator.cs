using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using TimeFutebol.Model;

namespace TimeFutebol.Validations
{
    public class TimeValidator : AbstractValidator<CadastroTimes>

    {
        public TimeValidator()
        {
            RuleFor(p => p.nome).NotEmpty().WithMessage("Nome do time é obrigatório!!")
                                .NotNull().WithMessage("Nome do time é obrigatório!!")
                                .MinimumLength(3).WithMessage("Nome deve ter pelo menos 3 caracteres!!");

            RuleFor(p => p.estado).NotEmpty().WithMessage("O Estado do time é obrigatório!!")
                                  .NotNull().WithMessage("O Estado do time é obrigatório!!")
                                  .MinimumLength(2).WithMessage("Ano deve ter pelo menos 2 caracteres!!");
        }

    }
}
