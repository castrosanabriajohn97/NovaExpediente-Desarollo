// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;
namespace NovaExpediente.Application.HerramientasCalidad.Commands.UpsertCalidad
{
    public class UpsertCalidadCommandValidator :AbstractValidator<UpsertCalidadCommand>
    {
        public UpsertCalidadCommandValidator()
        {
         
            RuleFor(x => x.Nombre).MaximumLength(100).NotEmpty();
           
        }
    }
}
