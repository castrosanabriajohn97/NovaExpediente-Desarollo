// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Infraestructuras.Queries.GetInfraestructuraDetalle
{
    public class GetInfraestructuraDetalleListQuery : IRequest<InfraestructuraDetalleVm>
    {
        public int Id { get; set; }
    }
}





