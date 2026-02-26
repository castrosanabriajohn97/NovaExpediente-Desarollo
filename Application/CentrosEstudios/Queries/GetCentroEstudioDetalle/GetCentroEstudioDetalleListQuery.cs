// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.CentrosEstudios.Queries.GetCentroEstudioDetalle
{
    public class GetCentroEstudioDetalleListQuery : IRequest<CentroEstudioDetalleVm>
    {
        public int Id { get; set; }
    }
}
