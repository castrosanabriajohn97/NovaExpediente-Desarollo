// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.Proyectos.Queries.GetProyectoDetalle
{
   public class GetProyectoDetalleListQuery : IRequest<ProyectoDetalleVm>
    {
        public int Id { get; set; }
    }
}





