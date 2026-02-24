// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Idiomas.Commands.UpsertIdiomas
{
    public class UpsertIdiomasCommandValidator : AbstractValidator <UpsertIdiomasCommand> 
    {
        public UpsertIdiomasCommandValidator()
        {
            RuleFor(x => x.Nombre).MaximumLength(100).NotEmpty();
            RuleFor(x => x.Descripcion).MaximumLength(500);
        }
    }
}
