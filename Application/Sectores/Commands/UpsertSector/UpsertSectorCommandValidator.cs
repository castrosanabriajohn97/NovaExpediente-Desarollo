// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Sectores.Commands.UpsertSector
{
    class UpsertSectorCommandValidator : AbstractValidator <UpsertSectorCommand>
    {
        public UpsertSectorCommandValidator()
        {
            RuleFor(x => x.Nombre).MaximumLength(100).NotEmpty();
        }
    }
}
