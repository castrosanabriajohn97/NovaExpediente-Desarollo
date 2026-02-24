// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.MasterDataTipoSolicitud.Queries.GetDetalleTipoSolicitud
{
    public class GetTipoSolicitudDetalleListQuery : IRequest<TipoSolicitudDetalleVm>
    {
        public int Id { get; set; }
    }
}
