// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.CurriculumVitae.Commands
{
    public class CargarCVCommandValidator : AbstractValidator<CargarCVCommand>
    {
        public CargarCVCommandValidator()
        {
        }
    }
}
