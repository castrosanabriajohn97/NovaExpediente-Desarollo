// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.AplicacionMovil.ConveniosCategorias.Commands.UpsertConveniosCategorias
{
    public class UpsertConveniosCategoriasCommandValidator : AbstractValidator<UpsertConveniosCategoriasCommand>
    {
        public UpsertConveniosCategoriasCommandValidator()
        {
            RuleFor(x => x.Nombre).MaximumLength(50).NotEmpty();
            RuleFor(x => x.Descripcion).MaximumLength(100).NotEmpty();
        }
    }
}
