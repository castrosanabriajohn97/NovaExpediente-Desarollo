// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Denuncias.Commands.IngresoDenuncias
{
    public class IngresoDenunciasCommandValidator : AbstractValidator<IngresoDenunciasCommand>
    {

        public IngresoDenunciasCommandValidator()
        {
            RuleFor(x => x.data).NotEmpty();
        }



 

    }
}
