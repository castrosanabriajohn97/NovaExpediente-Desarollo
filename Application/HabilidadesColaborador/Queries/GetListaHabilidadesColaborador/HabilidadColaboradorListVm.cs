// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.HabilidadesColaborador.Queries.GetListaHabilidadesColaborador
{
    public class HabilidadColaboradorListVm
    {
        public IList<HabilidadColaboradorDto> HabilidadesColaborador { get; set; }
        public int Id { get; set; }
        public int Count { get; set; }
    }
}
