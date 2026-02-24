// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
using FluentValidation;

namespace NovaExpediente.Application.Informes.Commands.InsertInformes
{
    public class InsertInformesCommandValidator : AbstractValidator<InsertInformesCommand>
    {
        public InsertInformesCommandValidator() => RuleFor(x => x.UserId).NotEmpty();
    }
}
