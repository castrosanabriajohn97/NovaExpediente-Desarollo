// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Idiomas.Queries.GetIdiomasDetalle
{
    public class GetIdiomaDetalleListQuery : IRequest<IdiomaDetalleVm>
    {
        public int Id { get; set; }
    }
}
