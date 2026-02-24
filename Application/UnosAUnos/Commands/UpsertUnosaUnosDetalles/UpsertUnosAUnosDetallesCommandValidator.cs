// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.UnosAUnos.Commands.UpsertUnosaUnosDetalles
{
    public class UpsertUnosAUnosDetallesCommandValidator : AbstractValidator<UpsertUnosAUnosDetallesCommand>
    {
        public UpsertUnosAUnosDetallesCommandValidator()
        {
            RuleFor(x => x.data).NotEmpty();
        }
    }
}
