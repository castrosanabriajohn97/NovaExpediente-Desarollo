// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.AplicacionMovil.ConveniosCategorias.Queries.GetConveniosCategorias
{
    public class ConveniosCategoriasVm
    {
        public IList<ConveniosCategoriasDto> ConveniosCategorias { get; set; }
        public int Count { get; set; }
    }
}
