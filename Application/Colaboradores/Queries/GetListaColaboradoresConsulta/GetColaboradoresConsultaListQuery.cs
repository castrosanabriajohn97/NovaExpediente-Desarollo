// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Colaboradores.Queries.GetListaColaboradoresConsulta
{
    public class GetColaboradoresConsultaListQuery : IRequest<ColaboradoresConsultaListVm>
    {
        public string Query { get; set; }
    }
}
