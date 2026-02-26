// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.CertificacionesProveedor.Queries.GetListaProveedorXCertificacion
{
   public class GetCertificacionProveedorXCertificacionListQuery : IRequest<CertificacionProveedorXCertificacionListVm>
    {
        public int Id { get; set; }
    }
}





