// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.ExperienciasProyectos.Queries.GetListaExperienciaProyecto
{
   public class GetExperienciaProyectoListQuery : IRequest<ExperienciaProyectoListVm>
    {
        public int Id { get; set; }
    }
}





