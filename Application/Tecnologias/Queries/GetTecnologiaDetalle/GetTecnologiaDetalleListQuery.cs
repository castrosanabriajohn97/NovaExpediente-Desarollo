// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Tecnologias.Queries.GetTecnologiaDetalle
{
   public class GetTecnologiaDetalleListQuery : IRequest<TecnologiaDetalleVm>
    {
       public int Id { get; set; }
    }
}





