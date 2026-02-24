// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Clientes.Commands.ValidaClienteDependencias
{
    class ValidaClienteDependenciasCommandValidator : AbstractValidator<ValidaClienteDependenciasCommand>
    {

        ValidaClienteDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
