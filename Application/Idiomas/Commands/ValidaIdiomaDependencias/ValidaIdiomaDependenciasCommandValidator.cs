// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Idiomas.Commands.ValidaIdiomaDependencias
{
    class ValidaIdiomaDependenciasCommandValidator : AbstractValidator<ValidaIdiomaDependenciasCommand>
    {

        ValidaIdiomaDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
