// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.LenguajesProgramacion.Commands.UpsertLenguajesProgramacion
{
    public class UpsertLenguajesProgramacionCommandValidator : AbstractValidator<UpsertLenguajesProgramacionCommand>
    {
        public UpsertLenguajesProgramacionCommandValidator()
        {

            RuleFor(x => x.Nombre).MaximumLength(100).NotEmpty();
        }
    }
}
