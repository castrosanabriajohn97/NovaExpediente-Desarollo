// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.ColaboradorProyectos.Queries.GetListaColaboradorProyectos
{
   public class GetColaboradorProyectoListQuery : IRequest<ColaboradorProyectoListVm>
    {
        public int Id { get; set; }
    }
}





