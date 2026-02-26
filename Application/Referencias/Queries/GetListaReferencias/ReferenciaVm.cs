// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.Referencias.Queries.GetListaReferencias
{
    public class ReferenciaVm
    {
        public IList<ReferenciaDto> Referencias { get; set; }

        public int Count { get; set; }
    }
}
