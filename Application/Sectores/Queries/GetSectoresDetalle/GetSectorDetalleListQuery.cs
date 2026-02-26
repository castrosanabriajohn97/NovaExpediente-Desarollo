// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Sectores.Queries.GetSectoresDetalle
{
    public class GetSectorDetalleListQuery : IRequest<SectorDetalleVm>
    {
        public int Id { get; set; }
    }
}
