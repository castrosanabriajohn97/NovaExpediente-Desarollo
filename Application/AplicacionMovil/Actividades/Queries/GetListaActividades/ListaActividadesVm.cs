// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.AplicacionMovil.Actividades.Queries.GetListaActividades
{
    public class ListaActividadesVm
    {
        public IList<ActividadDto> Actividades { get; set; }
        public int count;
    }
}
