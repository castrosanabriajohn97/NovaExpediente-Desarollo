// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.CursosColaborador.Queries.GetListaCursosColaborador
{
    public class CursoColaboradorListVm
    {
        public IList<CursoColaboradorDto> CursosColaborador { get; set; }
        public int Id { get; set; }
        public int Count { get; set; }
    }
}
