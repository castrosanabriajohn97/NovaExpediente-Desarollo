// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.Incapacidades.Queries.GetCargaIncapacidad
{
    public class CargaIncapacidadListVm
    {
        public IList<CargaIncapacidadDto> Cargas { get; set; }

        public int count;
    }
}
