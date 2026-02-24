// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
using FluentValidation;
namespace NovaExpediente.Application.Informes.Commands.InsertInformeMensaje
{
    public class InsertInformeMensajeCommandValidator : AbstractValidator<InsertInformeMensajeCommand>
    {
        public InsertInformeMensajeCommandValidator()
        {
            RuleFor(x => x.ConversationId).NotEmpty();
            RuleFor(x => x.UserId).NotEmpty();
            RuleFor(x => x.Message).NotEmpty();
        }
    }
}
