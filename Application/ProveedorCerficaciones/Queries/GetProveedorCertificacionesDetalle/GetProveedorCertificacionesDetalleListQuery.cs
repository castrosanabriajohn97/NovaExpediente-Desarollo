// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.ProveedorCerficaciones.Queries.GetProveedorCertificacionesDetalle
{
    public class GetProveedorCertificacionesDetalleListQuery : IRequest<ProveedorCertificacionesDetalleVm>
    {
        public int Id { get; set; }
    }
}
