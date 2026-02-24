// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Puestos.Commands.UpsertPuesto
{
    public class UpsertPuestoCommandValidator : AbstractValidator<UpsertPuestoCommand>
    { 
        public UpsertPuestoCommandValidator()
        {
            RuleFor(x => x.Nombre).MaximumLength(100).NotEmpty();
        }
    }
}
