// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.AplicacionMovil.Noticias.Commands.UpsertNoticias
{
    public class UpsertNoticiasCommandValidator : AbstractValidator<UpsertNoticiasCommand>
    {

        public UpsertNoticiasCommandValidator()
        {
            RuleFor(x => x.data).NotEmpty();
        }



 

    }
}
