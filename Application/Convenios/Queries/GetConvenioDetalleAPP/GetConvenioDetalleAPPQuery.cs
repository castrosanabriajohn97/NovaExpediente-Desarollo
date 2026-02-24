// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Convenios.Queries.GetConvenioDetalleAPP
{
    public class GetConvenioDetalleAPPQuery : IRequest<string>
    {
        public int Id { get; set; }
    }
}