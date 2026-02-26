// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.HablilidadesBlandas.Queries.GetListaHabilidadesBlandas
{
     public class HabilidadesBlandasListVm
    {
        public IList<HabilidadesBlandasDto> habilidadesBlandas { get; set; }

        public int Count { get; set; }
    }
}
