// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Paises.Commands.UpsertPais
{
    class UpsertPaisCommandValidator : AbstractValidator<UpsertPaisCommand>
    {

        public UpsertPaisCommandValidator()
        {
            RuleFor(x => x.Nombre).MaximumLength(100).NotEmpty();
        }
    }
}
