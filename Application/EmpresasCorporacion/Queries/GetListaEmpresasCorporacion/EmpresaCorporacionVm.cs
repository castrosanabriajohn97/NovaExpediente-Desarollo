// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.EmpresasCorporacion.Queries.GetListaEmpresasCorporacion
{
    public class EmpresaCorporacionVm
    {
        public IList<EmpresaCorporacionDto> EmpresaCorporacions { get; set; }

        public int Count { get; set; }
    }
}
