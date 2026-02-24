// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.Infraestructuras.Queries.GetListaInfraestructura
{
    public class InfraestructuraVm
    {
        public IList<InfraestructuraDto> Infraestructuras { get; set; }

        public int Count { get; set; }
    }
}
