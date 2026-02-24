// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.BPMS.Queries.GetBPMDetalle
{
    public class GetBPMDetalleListQuery : IRequest<BPMDetalleVm>
    {
        public int Id { get; set; }
    }
}
