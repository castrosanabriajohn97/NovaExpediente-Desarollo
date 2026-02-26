// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.CertificacionesColaborador.Queries.GetCertificacionDocumento
{
    public class GetCertificacionDocumentoByIdQuery : IRequest<CertificacionDocumentoVm>
    {
        public int Id { get; set; }
    }
}
