// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.CertificacionesColaborador.Queries.GetCertificacionColaboradorDetalle
{
   public class GetCertificacionColaboradorDetalleListQuery : IRequest<CertificacionColaboradorDetalleVm>
    {
        public int Id { get; set; }
    }
}





