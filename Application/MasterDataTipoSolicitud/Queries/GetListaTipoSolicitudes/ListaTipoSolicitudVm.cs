// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.MasterDataTipoSolicitud.Queries.GetListaTipoSolicitudes
{
    public class ListTipoSolicitudVm
    {
        public IList<TipoSolicitudDto> TiposSolicitudes { get; set; }

        public int count;
    }
}
