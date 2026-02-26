// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.EmpresasCorporacion.Commands.UpsertEmpresasCorporacion
{
    public class UpsertEmpresasCorporacionCommandValidator : AbstractValidator<UpsertEmpresasCorporacionCommand>
    {
        public UpsertEmpresasCorporacionCommandValidator() {
            RuleFor(x => x.Nombre).MaximumLength(100).NotEmpty();
        }

    }
}
