// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Buses.Queries.GetBusDetalle
{
    public class GetBusDetalleListQuery : IRequest<BusDetalleVm>
    {
        public int Id { get; set; }
    }
}





