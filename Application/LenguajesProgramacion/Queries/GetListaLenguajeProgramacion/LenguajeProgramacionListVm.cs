// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.LenguajesProgramacion.Queries.GetListaLenguajeProgramacion
{
    public class LenguajeProgramacionListVm
    {
        public IList<LenguajeProgramacionDto> LenguajesProgramacion { get; set; }

        public int Count { get; set; }
    }
}
