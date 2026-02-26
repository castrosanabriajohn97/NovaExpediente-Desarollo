// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.ColaboradorProyectos.Queries.GetListaColaboradorProyectos
{
    public class ColaboradorProyectoVm
    {
        public IList<ColaboradorProyectoDto> ColaboradorProyectos { get; set; }

        public int Count { get; set; }
    }
}
