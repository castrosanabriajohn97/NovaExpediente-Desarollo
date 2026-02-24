// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Puestos.Commands.ValidaPuestoDependencias
{
    class ValidaPuestoDependenciasCommandValidator : AbstractValidator<ValidaPuestoDependenciasCommand>
    {

        ValidaPuestoDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
