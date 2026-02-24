// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.HerramientasCalidad.Queries.GetListaCalidad
{
    public class CalidadVm
    {
        public IList<CalidadDto> Calidads { get; set; }

        public int Count { get; set; }
    }
}
