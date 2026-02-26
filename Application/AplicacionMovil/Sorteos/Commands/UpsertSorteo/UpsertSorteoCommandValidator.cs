// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.AplicacionMovil.Sorteos.Commands.UpsertSorteo
{
    public class UpsertSorteoCommandValidator : AbstractValidator<UpsertSorteoCommand>
    {
        public UpsertSorteoCommandValidator()
        {
            RuleFor(x => x.Data).NotEmpty();
        }
    }
}
