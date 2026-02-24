// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.AplicacionMovil.Eventos.GetListaEventos
{
    public class ListaEventosVm
    {
        public IList<EventoDto> Eventos { get; set; }
        public int Count;
    }
}
