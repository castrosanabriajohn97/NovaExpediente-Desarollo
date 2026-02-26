// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Puestos.Queries.GetPuestoDetalle
{
    public class GetPuestoDetalleListQuery : IRequest<PuestoDetalleVm>
    {
        public int Id { get; set; }
    }
}
