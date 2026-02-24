// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.Paises.Queries.GetListaPais
{
    public class PaisListVm
    {
        public IList<PaisDto> Paises { get; set; }

        public int Count { get; set; }
    }
}
