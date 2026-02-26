// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using FluentValidation;

namespace NovaExpediente.Application.Colaboradores.Commands.ReasignarDMPorCliente
{
    public class ReasignarDMPorClienteCommandValidator : AbstractValidator<ReasignarDMPorClienteCommand>
    {


        public ReasignarDMPorClienteCommandValidator()
        {
            RuleFor(x => x.IdCliente).NotNull();
            RuleFor(x => x.IdDM).NotNull();
            RuleFor(x => x.IdDMOld).NotNull();
        }


    }
}
