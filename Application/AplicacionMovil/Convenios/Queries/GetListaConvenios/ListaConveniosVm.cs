// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.AplicacionMovil.Convenios.Queries.GetListaConvenios
{
    public class ListaConveniosVm
    {
        public IList<ConvenioDto> Convenios { get; set; }
        public int count;
    }
}
