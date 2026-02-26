// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Provincias.Commands.UpsertProvincia
{
    class UpsertProvinciaCommandValidator : AbstractValidator<UpsertProvinciaCommand>
    {

        public UpsertProvinciaCommandValidator()
        {
            RuleFor(x => x.Nombre).MaximumLength(100).NotEmpty();
        }
    }
}
