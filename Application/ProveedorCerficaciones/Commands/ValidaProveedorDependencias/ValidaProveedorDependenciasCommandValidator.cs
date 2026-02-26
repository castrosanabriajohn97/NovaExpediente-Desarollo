// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.ProveedorCerficaciones.Commands.ValidaProveedorDependencias
{
    class ValidaProveedorDependenciasCommandValidator : AbstractValidator<ValidaProveedorDependenciasCommand>
    {

        ValidaProveedorDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
