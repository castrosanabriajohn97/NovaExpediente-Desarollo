// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.HerramientasCalidad.Commands.ValidaCalidadDependencias
{
    class ValidaCalidadDependenciasCommandValidator : AbstractValidator<ValidaCalidadDependenciasCommand>
    {

        ValidaCalidadDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
