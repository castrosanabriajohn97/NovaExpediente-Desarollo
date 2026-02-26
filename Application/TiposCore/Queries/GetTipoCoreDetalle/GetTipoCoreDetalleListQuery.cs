// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.TiposCore.Queries.GetTipoCoreDetalle
{
    public class GetTipoCoreDetalleListQuery : IRequest<TipoCoreDetalleVm>
    {
        public int Id { get; set; }
    }
}
