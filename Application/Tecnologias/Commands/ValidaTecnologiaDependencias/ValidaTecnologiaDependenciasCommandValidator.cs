// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Tecnologias.Commands.ValidaTecnologiaDependencias
{
    class ValidaTecnologiaDependenciasCommandValidator : AbstractValidator<ValidaTecnologiaDependenciasCommand>
    {

        ValidaTecnologiaDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
