// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.Certificaciones.Queries.GetListaCertificacion
{
    public class CertificacionListVm
    {
        public IList<CertificacionDto> Certificaciones { get; set; }

        public int Count { get; set; }
    }
}
