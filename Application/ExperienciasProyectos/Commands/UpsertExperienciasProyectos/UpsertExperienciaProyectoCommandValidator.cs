// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.ExperienciasProyectos.Commands.UpsertExperienciasProyectos
{
    class UpsertExperienciaProyectoCommandValidator : AbstractValidator<UpsertExperienciaProyectoCommand>
    {

        UpsertExperienciaProyectoCommandValidator()
        {
            RuleFor(x => x.IDCOLABORADOR).NotNull().NotEmpty();
            RuleFor(x => x.NOMBREPROYECTO).NotNull().NotEmpty().MaximumLength(1000);
            RuleFor(x => x.DESCRIPCION).MaximumLength(8000);
            RuleFor(x => x.NOMBRECLIENTE).NotNull().NotEmpty().MaximumLength(100);
            RuleFor(x => x.INICIO).NotNull();
            RuleFor(x => x.FIN).NotNull();
            RuleFor(x => x.ROLPROYECTO).MaximumLength(100);
            RuleFor(x => x.LICITACION).MaximumLength(100);





        }
    }
}
