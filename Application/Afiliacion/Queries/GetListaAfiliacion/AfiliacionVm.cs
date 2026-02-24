// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using NovaExpediente.Application.Afiliacion.Queries.GetAfiliacionDetalle;
using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.Afiliacion.Queries.GetListaAfiliacion
{ 
    public class AfiliacionVm
    {
        public IList<AfiliacionColaboradorDto> Afiliaciones { get; set; }

        public int Count { get; set; }
    }
}
