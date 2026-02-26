// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.HablilidadesBlandas.Commands.UpsertHabilidadBlanda
{
    class UpsertHabilidadBlandaCommandValidator : AbstractValidator<UpsertHabilidadBlandaCommand>
    {
        public UpsertHabilidadBlandaCommandValidator()
        {

            RuleFor(x => x.Nombre).MaximumLength(100).NotEmpty();

        }
    }
}
