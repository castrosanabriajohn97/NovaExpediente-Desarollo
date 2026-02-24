// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.CertificacionesProveedor.Commands.ValidaCertificacionProveedorDependencias
{
    class ValidaCertificacionProveedorDependenciasCommandValidator : AbstractValidator<ValidaCertificacionProveedorDependenciasCommand>
    {

        ValidaCertificacionProveedorDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
