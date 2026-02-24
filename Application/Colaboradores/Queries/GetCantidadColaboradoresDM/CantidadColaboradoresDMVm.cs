// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.Colaboradores.Queries.GetCantidadColaboradoresDM
{
    public class CantidadColaboradoresDMVm
    {
        public IList<CantidadColaboradoresDMDto> Colaboradores { get; set; }

        public int Count { get; set; }
    }
}
