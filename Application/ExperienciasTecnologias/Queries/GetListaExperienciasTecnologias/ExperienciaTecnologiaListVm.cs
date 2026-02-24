// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.ExperienciasTecnologias.Queries.GetListaExperienciasTecnologias
{
    public class ExperienciaTecnologiaListVm
    {
        public IList<ExperienciaTecnologiaDto> ExperienciaTecnologias { get; set; }
        public int Id { get; set; }
        public int Count { get; set; }
    }
}
