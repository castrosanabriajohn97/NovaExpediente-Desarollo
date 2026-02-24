// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.Especialidades.Queries.GetListaEspecialidadConsulta
{
    public class EspecialidadConsultaVm
    {
        public IList<EspecialidadConsultaDto> Especialidades { get; set; }

        public int Count { get; set; }
    }
}
