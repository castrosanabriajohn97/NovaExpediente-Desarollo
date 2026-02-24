// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.Distritos.Queries.GetListaDistrito
{
    public class DistritoListVm
    {
        public IList<DistritoDto> Distritos { get; set; }

        public int Count { get; set; }
    }
}
