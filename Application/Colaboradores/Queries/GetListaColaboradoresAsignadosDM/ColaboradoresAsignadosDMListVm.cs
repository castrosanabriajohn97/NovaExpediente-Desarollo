// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.Colaboradores.Queries.GetListaColaboradoresAsignadosDM
{
    public class ColaboradoresAsignadosDMListVm
    {
        public IList<ColaboradoresAsignadosDMDto> Colaboradores { get; set; }

        public int Count { get; set; }
    }
}
