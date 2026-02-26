// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.ProyectoClasificadores.Queries.GetListaProyectoClasificador
{
   public class GetProyectoClasificadorListQuery : IRequest<ProyectoClasificadorListVm>
    {
        public int Id { get; set; }
    }
}





