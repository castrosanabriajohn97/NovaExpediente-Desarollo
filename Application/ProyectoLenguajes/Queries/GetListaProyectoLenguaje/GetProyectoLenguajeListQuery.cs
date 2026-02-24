// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.ProyectoLenguajes.Queries.GetListaProyectoLenguaje
{
   public class GetProyectoLenguajeListQuery : IRequest<ProyectoLenguajeListVm>
    {
        public int Id { get; set; }
    }
}





