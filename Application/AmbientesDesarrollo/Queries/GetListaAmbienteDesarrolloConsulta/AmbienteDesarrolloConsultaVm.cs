// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.AmbientesDesarrollo.Queries.GetListaAmbienteDesarrolloConsulta
{
    public class AmbienteDesarrolloConsultaVm
    {
        public IList<AmbienteDesarrolloConsultaDto> AmbientesDesarrollo { get; set; }

        public int Count { get; set; }
    }
}
