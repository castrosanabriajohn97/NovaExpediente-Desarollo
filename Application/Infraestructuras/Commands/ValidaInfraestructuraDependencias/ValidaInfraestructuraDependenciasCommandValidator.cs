// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Infraestructuras.Commands.ValidaInfraestructuraDependencias
{
    class ValidaInfraestructuraDependenciasCommandValidator : AbstractValidator<ValidaInfraestructuraDependenciasCommand>
    {

        ValidaInfraestructuraDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
