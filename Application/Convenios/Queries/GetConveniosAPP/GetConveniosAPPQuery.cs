// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Convenios.Queries.GetConveniosAPP
{
    public class GetConveniosAPPQuery : IRequest<string>
    {
        public int IdIdioma { get; set; }
        public int IdCategoria { get; set; }
    }
}