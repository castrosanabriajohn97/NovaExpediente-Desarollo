// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.TiposCore.Commands.ValidaTipoCoreDependencias
{
    class ValidaTipoCoreDependenciasCommandValidator : AbstractValidator<ValidaTipoCoreDependenciasCommand>
    {

        ValidaTipoCoreDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
