// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.AreasOrganizativas.Commands.ValidaAreaOrganizativaDependencias
{
    class ValidaAreaOrganizativaDependenciasCommandValidator : AbstractValidator<ValidaAreaOrganizativaDependenciasCommand>
    {

        ValidaAreaOrganizativaDependenciasCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();

        }
    }
}
