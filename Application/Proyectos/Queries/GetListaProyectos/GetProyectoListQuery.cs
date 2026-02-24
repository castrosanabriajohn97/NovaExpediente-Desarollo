// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Proyectos.Queries.GetListaProyectos
{
   public class GetProyectoListQuery : IRequest<ProyectoListVm>
    {
        public int Id { get; set; }
    }
}





