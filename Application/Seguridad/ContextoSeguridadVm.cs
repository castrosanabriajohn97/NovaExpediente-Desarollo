// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaExpediente.Application.Seguridad
{
    public class ContextoSeguridadVm
    {
        public IList<string> Roles{ get; set; }
        public IList<string> Permisos { get; set; }
    }
}
