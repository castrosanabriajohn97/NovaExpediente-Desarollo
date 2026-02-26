// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.TiposPermisoGoce.Queries.GetListaTipoPermisoGoce
{
    public class TipoPermisoGoceListVm
    {
        public IList<TipoPermisoGoceDto> TiposPermisoGoce { get; set; }
        public int Count { get; set; }
    }
}
