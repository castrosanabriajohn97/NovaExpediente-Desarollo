// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Colaboradores.Queries.GetListaColaboradoresCV
{
    public class GetColaboradoresCVListQuery : IRequest<ColaboradoresCVVm>
    {
        public string Query { get; set; }
        public int TipoCV { get; set; }
    }
}
