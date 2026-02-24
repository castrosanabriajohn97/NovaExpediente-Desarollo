// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.BasesDatos.Commands.UpsertBaseDatos
{
    class UpsertBaseDatosCommandValidator : AbstractValidator<UpsertBaseDatosCommand>
    {
        public UpsertBaseDatosCommandValidator()
        {
           
            RuleFor(x => x.Nombre).MaximumLength(100).NotEmpty();

        }
    }
}
