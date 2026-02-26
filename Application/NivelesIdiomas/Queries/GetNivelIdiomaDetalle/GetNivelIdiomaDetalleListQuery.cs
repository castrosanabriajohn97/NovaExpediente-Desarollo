// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.NivelesIdiomas.Queries.GetNivelIdiomaDetalle
{
   public class GetNivelIdiomaDetalleListQuery : IRequest<NivelIdiomaDetalleVm>
    {
        public int Id { get; set; }

    }
}





