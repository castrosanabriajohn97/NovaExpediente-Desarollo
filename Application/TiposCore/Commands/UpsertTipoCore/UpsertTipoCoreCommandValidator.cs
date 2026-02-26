// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.TiposCore.Commands.UpsertTipoCore
{
    class UpsertTipoCoreCommandValidator :AbstractValidator<UpsertTipoCoreCommand>
    {
        public UpsertTipoCoreCommandValidator()
        {
            RuleFor(x => x.Nombre).MaximumLength(100).NotEmpty();
        }
    }
}
