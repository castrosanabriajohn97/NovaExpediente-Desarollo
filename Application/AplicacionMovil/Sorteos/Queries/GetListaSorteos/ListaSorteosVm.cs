// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.AplicacionMovil.Sorteos.Queries.GetListaSorteos
{
    public class ListaSorteosVm
    {
        public IList<SorteoDto> Sorteos { get; set; }
        public int Count;
    }
}
