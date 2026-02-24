// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Empresas.Commands.UpsertEmpresas
{
    public class UpsertEmpresasCommandValidator : AbstractValidator<UpsertEmpresasCommand>
    {
        public UpsertEmpresasCommandValidator() {
            RuleFor(x => x.Nombre).MaximumLength(100).NotEmpty();
            RuleFor(x => x.cedulaJuridica).MaximumLength(100).NotEmpty();
        }

    }
}
