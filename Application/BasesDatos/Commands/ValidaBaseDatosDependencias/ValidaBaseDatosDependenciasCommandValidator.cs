// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.BasesDatos.Commands.ValidaBaseDatosDependencias
{
    class ValidaBaseDatosDependenciasCommandValidator : AbstractValidator<ValidaBaseDatosDependenciasCommand>
    {

        ValidaBaseDatosDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
