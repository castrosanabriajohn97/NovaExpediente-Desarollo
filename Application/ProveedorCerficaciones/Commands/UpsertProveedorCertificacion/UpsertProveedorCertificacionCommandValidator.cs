// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.ProveedorCerficaciones.Commands.UpsertProveedorCertificacion
{
    public class UpsertProveedorCertificacionCommandValidator : AbstractValidator<UpsertProveedorCertificacionCommand>
    {
        public UpsertProveedorCertificacionCommandValidator()
        {
            RuleFor(x => x.Nombre).MaximumLength(100).NotEmpty();
        }

        
    }
}
