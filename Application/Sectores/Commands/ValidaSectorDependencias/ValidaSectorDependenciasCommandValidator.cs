// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Sectores.Commands.ValidaSectorDependencias
{
    class ValidaSectorDependenciasCommandValidator : AbstractValidator<ValidaSectorDependenciasCommand>
    {

        ValidaSectorDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
