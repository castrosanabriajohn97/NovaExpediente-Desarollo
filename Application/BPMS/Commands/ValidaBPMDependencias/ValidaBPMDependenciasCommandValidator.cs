// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.BPMS.Commands.ValidaBPMDependencias
{
    class ValidaBPMDependenciasCommandValidator : AbstractValidator<ValidaBPMDependenciasCommand>
    {

        ValidaBPMDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
