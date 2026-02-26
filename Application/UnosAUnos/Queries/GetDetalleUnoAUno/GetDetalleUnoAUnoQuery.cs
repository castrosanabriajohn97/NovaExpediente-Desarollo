// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.UnosAUnos.Queries.GetDetalleUnoAUno
{
    public class GetDetalleUnoAUnoQuery : IRequest<string>
    {
        public int IdUnoAUno { get; set; }
    }
}
