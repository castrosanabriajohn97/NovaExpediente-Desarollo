// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.AreasOrganizativas.Commands.UpsertAreaOrganizativa
{
    public class UpsertAreaOrganizativaCommandValidator: AbstractValidator<UpsertAreaOrganizativaCommand>
    {
        public UpsertAreaOrganizativaCommandValidator()
        {
            RuleFor(x => x.Nombre).MaximumLength(100).NotEmpty();
        }

    }
}
