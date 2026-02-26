// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Cantones.Commands.UpsertCanton
{
    class UpsertCantonCommandValidator : AbstractValidator<UpsertCantonCommand>
    {

        public UpsertCantonCommandValidator()
        {
            RuleFor(x => x.Nombre).MaximumLength(100).NotEmpty();
            RuleFor(x => x.IdProvincia).NotNull();
        }
    }
}
