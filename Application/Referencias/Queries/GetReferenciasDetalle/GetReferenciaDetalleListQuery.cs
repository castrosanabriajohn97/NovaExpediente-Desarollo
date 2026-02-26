// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Referencias.Queries.GetReferenciasDetalle
{
   public class GetReferenciaDetalleListQuery : IRequest<ReferenciaDetalleVm>
    {
        public int Id { get; set; }
    }
}





