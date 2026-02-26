// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.Proyectos.Queries.GetListaProyectos
{
    public class ProyectoVm
    {
        public IList<ProyectoDto> Proyectos { get; set; }

        public int Count { get; set; }
    }
}
