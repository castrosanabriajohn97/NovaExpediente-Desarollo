// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.UnosAUnosEstados.Queries.GetListaUnosAUnosEstados
{
    public class ListaUnosAUnosEstadosVm
    {
        public IList<UnosAUnosEstadosDto> unosAUnosEstados { get; set; }
        public int count;
    }
}
