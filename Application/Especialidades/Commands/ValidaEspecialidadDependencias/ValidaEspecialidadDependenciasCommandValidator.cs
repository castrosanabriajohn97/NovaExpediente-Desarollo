// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Especialidades.Commands.ValidaEspecialidadDependencias
{
    class ValidaEspecialidadDependenciasCommandValidator : AbstractValidator<ValidaEspecialidadDependenciasCommand>
    {

        ValidaEspecialidadDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
