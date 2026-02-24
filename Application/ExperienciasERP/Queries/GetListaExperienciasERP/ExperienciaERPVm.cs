// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.ExperienciasERP.Queries.GetListaExperienciasERP
{
    public class ExperienciaERPVm
    {
        public IList<ExperienciaERPDto> ExperienciasERPs { get; set; }

        public int Count { get; set; }
    }
}
