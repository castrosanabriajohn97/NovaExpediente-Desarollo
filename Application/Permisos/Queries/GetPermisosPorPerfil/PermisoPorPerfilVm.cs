// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.Permisos.Queries.GetPermisosPorPerfil  
{
    public class PermisoPorPerfilVm
    {
        public IList<PermisoPerfilDto> Permisos { get; set; }
        public int Count { get; set; }
    }
}
