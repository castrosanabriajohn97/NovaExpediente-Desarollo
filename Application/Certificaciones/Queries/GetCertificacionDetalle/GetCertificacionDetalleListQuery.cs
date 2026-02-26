// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Certificaciones.Queries.GetCertificacionDetalle
{
    public class GetCertificacionDetalleListQuery : IRequest<CertificacionDetalleVm>
    {
        public int Id { get; set; }
    }
}





