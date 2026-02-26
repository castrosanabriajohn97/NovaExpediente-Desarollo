// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.CertificacionesColaborador.Queries.GetListaCertificacionColaborador
{
   public class GetCertificacionColaboradorListQuery : IRequest<CertificacionColaboradorListVm>
    {
        public int Id { get; set; }
    }
}





