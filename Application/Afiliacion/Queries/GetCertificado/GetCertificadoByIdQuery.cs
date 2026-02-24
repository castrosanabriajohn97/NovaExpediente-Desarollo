// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Afiliacion.Queries.GetCertificado
{
   public class GetCertificadoByIdQuery : IRequest<CertificadoAfiliacionVm>
    {
        public int Id { get; set; }
    }
}





