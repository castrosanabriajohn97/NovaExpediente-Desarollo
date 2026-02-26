// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.AplicacionMovil.Actividades.Commands.UpsertActividades
{
    public class UpsertActividadesCommandValidator : AbstractValidator<UpsertActividadesCommand>
    {

        public UpsertActividadesCommandValidator()
        {
            RuleFor(x => x.data).NotEmpty();
        }



 

    }
}
