// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.CertificacionesProveedor.Commands.ValidaProveedorCertificacionDependencias
{
    class ValidaProveedorCertificacionDependenciasCommandValidator : AbstractValidator<ValidaProveedorCertificacionDependenciasCommand>
    {

        ValidaProveedorCertificacionDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
