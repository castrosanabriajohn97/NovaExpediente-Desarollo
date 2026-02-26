// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.ExperienciasLenguajes.Queries.GetListaExperienciasLenguajes
{
    public class ExperienciaLenguajeVm
    {
        public IList<ExperienciaLenguajeDto> ExperienciaLenguajes { get; set; }

        public int Count { get; set; }
    }
}
