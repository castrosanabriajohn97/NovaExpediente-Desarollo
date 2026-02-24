// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.Puestos.Queries.GetListaPuesto
{
    public class PuestoListVm
    {
        public IList<PuestoDto> Puesto { get; set; }
        public int Count { get; set; }
    }
}
