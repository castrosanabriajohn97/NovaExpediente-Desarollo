// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.MasterData.Queries.GetCantidadSolicitudes
{
    public class GetCantidadSolicitudesQuery : IRequest<CantidadSolicitudesVm>
    {
        public string Categoria { get; set; }
    }
}
