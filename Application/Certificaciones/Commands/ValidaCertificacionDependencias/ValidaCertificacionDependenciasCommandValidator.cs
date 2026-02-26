// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Certificaciones.Commands.ValidaCertificacionDependencias
{
    class ValidaCertificacionDependenciasCommandValidator : AbstractValidator<ValidaCertificacionDependenciasCommand>
    {

        ValidaCertificacionDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
