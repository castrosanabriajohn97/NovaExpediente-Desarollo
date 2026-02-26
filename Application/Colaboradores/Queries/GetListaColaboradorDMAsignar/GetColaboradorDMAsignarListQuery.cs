// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Colaboradores.Queries.GetListaColaboradorDMAsignar
{
   public class GetColaboradorDMAsignarListQuery : IRequest<ColaboradorDMAsignarListVm>
    {
        public int Id { get; set; }
    }
}





