// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.ProyectoTecnologias.Queries.GetListaProyectoTecnologia
{
   public class GetProyectoTecnologiaListQuery : IRequest<ProyectoTecnologiaListVm>
    {
        public int Id { get; set; }
    }
}





