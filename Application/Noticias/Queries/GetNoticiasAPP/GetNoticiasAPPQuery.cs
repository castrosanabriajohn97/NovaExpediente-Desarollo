// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Noticias.Queries.GetNoticiasAPP
{
    public class GetNoticiasAPPQuery : IRequest<string>
    {
        public bool EsPublica { get; set; }
        public int IdIdioma { get; set; }
    }
}