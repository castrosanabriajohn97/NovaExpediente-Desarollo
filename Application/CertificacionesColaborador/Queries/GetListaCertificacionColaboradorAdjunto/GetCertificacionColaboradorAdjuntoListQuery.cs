// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.CertificacionesColaborador.Queries.GetListaCertificacionColaboradorAdjunto
{
   public class GetCertificacionColaboradorAdjuntoListQuery : IRequest<CertificacionColaboradorAdjuntoListVm>
    {
        public int Id { get; set; }
    }
}





