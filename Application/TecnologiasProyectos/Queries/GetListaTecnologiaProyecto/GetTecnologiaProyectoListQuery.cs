// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.TecnologiasProyectos.Queries.GetListaTecnologiaProyecto
{
   public class GetTecnologiaProyectoListQuery : IRequest<TecnologiaProyectoListVm>
    {
        public int Id { get; set; }
    }
}





