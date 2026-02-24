// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.AmbientesDesarrollo.Commands.ValidaAmbienteDependencias
{
    class ValidaAmbienteDependenciasCommandValidator : AbstractValidator<ValidaAmbienteDependenciasCommand>
    {

        ValidaAmbienteDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
