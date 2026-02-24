// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.EspecialidadesConsultor.Queries.GetListaEspecialidadConsultor
{ 
    public class EspecialidadConsultorVm
    {
        public IList<EspecialidadConsultorDto> EspecialidadesConsultor { get; set; }

        public int Count { get; set; }
    }
}
