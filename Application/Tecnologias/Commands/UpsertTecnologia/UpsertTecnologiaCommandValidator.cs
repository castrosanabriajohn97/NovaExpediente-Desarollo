// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Tecnologias.Commands.UpsertTecnologia
{
    class UpsertTecnologiaCommandValidator : AbstractValidator<UpsertTecnologiaCommand>
    {
        public UpsertTecnologiaCommandValidator()
        {

            RuleFor(x => x.Nombre).MaximumLength(100).NotEmpty();

        }
    }
}
