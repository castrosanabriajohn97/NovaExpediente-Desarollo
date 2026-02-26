// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.AplicacionMovil.Convenios.Commands.UpsertConvenios
{
    public class UpsertConveniosCommandValidator : AbstractValidator<UpsertConveniosCommand>
    {

        public UpsertConveniosCommandValidator()
        {
            RuleFor(x => x.data).NotEmpty();
        }



 

    }
}
