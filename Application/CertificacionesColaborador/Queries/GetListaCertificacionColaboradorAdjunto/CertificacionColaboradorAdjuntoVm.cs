// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.CertificacionesColaborador.Queries.GetListaCertificacionColaboradorAdjunto
{
    public class CertificacionColaboradorAdjuntoVm
    {
        public IList<CertificacionColaboradorAdjuntoDto> CertificacionsColaborador { get; set; }

        public int Count { get; set; }
    }
}
