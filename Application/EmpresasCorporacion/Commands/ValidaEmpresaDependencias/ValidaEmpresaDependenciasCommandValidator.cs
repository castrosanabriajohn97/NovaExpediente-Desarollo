// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.EmpresasCorporacion.Commands.ValidaEmpresaDependencias
{
    class ValidaEmpresaDependenciasCommandValidator : AbstractValidator<ValidaEmpresaDependenciasCommand>
    {

        ValidaEmpresaDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
