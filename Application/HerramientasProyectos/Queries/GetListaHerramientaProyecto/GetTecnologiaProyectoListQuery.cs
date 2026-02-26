// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.HerramientasProyectos.Queries.GetListaHerramientaProyecto
{
   public class GetHerramientaProyectoListQuery : IRequest<HerramientaProyectoListVm>
    {
        public int Id { get; set; }
    }
}





