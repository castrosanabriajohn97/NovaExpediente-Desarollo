// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.CentrosEstudios.Commands.UpsertCentroEstudio
{
    public class UpsertCentroEstudioCommandValidator : AbstractValidator<UpsertCentroEstudioCommand>
    {
        public UpsertCentroEstudioCommandValidator()
        {
            RuleFor(x => x.Nombre).MaximumLength(100).NotEmpty();
        }
    }
}
