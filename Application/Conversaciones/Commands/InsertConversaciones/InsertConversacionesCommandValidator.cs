// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Conversaciones.Commands.InsertConversaciones
{
    public class InsertConversacionesCommandValidator : AbstractValidator<InsertConversacionesCommand>
    {
        public InsertConversacionesCommandValidator()
        {
            RuleFor(x => x.userId).NotEmpty();
        }
    }
}
