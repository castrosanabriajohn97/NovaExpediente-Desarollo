// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.AplicacionMovil.Sorteos.Queries.GetDetalleSorteo
{
    public class GetDetalleSorteoQuery : IRequest<string>
    {
        public int IdSorteo { get; set; }
    }
}
