// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.CentrosEstudios.Commands.ValidaCentroEstudioDependencias
{
    class ValidaCentroEstudioDependenciasCommandValidator : AbstractValidator<ValidaCentroEstudioDependenciasCommand>
    {

        ValidaCentroEstudioDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
