// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Clouds.Commands.ValidaCloudDependencias
{
    class ValidaCloudDependenciasCommandValidator : AbstractValidator<ValidaCloudDependenciasCommand>
    {

        ValidaCloudDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
