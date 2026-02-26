// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.UnosAUnos.Queries.GetListaUnosAUnos
{
    public class ListaUnosAUnosVm
    {
        public IList<UnoAUnoDto> unosAUnos { get; set; }
        public int count;
    }
}
