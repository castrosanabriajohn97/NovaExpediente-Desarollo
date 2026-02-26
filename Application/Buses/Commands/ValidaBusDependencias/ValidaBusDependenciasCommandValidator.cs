// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Buses.Commands.ValidaBusDependencias
{
    class ValidaBusDependenciasCommandValidator : AbstractValidator<ValidaBusDependenciasCommand>
    {

        ValidaBusDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
