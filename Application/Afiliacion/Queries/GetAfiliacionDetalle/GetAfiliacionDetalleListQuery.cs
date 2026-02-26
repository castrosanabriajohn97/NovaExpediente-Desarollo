// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;
using NovaExpediente.Application.Afiliacion.Queries.AfiliacionDetalle;

namespace NovaExpediente.Application.Afiliacion.Queries.GetListaAfiliacionDetalle
{
   public class GetAfiliacionDetalleListQuery : IRequest<AfiliacionDetalleVm>
    {
        public int Id { get; set; }
    }
}





