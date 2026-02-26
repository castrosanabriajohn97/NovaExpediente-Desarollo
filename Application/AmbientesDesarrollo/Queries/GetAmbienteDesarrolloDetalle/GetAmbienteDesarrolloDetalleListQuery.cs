// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.AmbientesDesarrollo.Queries.GetAmbienteDesarrolloDetalle
{
   public class GetAmbienteDesarrolloDetalleListQuery : IRequest<AmbienteDesarrolloDetalleVm>
    {
        public int Id { get; set; }

    }
}





