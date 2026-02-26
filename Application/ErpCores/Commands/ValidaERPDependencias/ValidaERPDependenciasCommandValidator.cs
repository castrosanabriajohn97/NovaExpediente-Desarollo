// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.ErpCores.Commands.ValidaERPDependencias
{
    class ValidaERPDependenciasCommandValidator : AbstractValidator<ValidaERPDependenciasCommand>
    {

        ValidaERPDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
