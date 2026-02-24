// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Colaboradores.Queries.GetListaColaboradoresAsignadosDM
{
    public class GetColaboradoresAsignadosListQuery : IRequest<ColaboradoresAsignadosDMListVm>
    {
        public int IdDM { get; set; }
    }
}
