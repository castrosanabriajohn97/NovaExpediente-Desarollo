// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.ExperienciasProyectos.Queries.GetExperienciaProyectoDetalle
{
   public class GetExperienciaProyectoDetalleListQuery : IRequest<ExperienciaProyectoDetalleVm>
    {
        public int Id { get; set; }
    }
}





