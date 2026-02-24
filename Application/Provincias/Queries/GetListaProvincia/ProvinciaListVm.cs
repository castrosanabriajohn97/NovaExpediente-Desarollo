// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.Provincias.Queries.GetListaProvincia
{
    public class ProvinciaListVm
    {
        public IList<ProvinciaDto> Provincias { get; set; }

        public int Count { get; set; }
    }
}
