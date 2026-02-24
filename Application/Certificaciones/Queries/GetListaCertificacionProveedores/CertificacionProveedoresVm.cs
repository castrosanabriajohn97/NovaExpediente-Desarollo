// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.Certificaciones.Queries.GetListaCertificacionProveedores
{
    public class CertificacionProveedoresVm
    {
        public IList<CertificacionProveedoresDto> CertificacionesProveedores { get; set; }

        public int Count { get; set; }
    }
}
