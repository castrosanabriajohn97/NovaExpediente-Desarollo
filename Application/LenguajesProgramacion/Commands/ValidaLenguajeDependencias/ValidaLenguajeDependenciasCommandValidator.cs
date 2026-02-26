// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.LenguajesProgramacion.Commands.ValidaLenguajeDependencias
{
    class ValidaLenguajeDependenciasCommandValidator : AbstractValidator<ValidaLenguajeDependenciasCommand>
    {

        ValidaLenguajeDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
