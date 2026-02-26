// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.ExperienciasCalidad.Queries.GetListaExperienciasCalidad
{
   public class GetExperienciaCalidadListQuery : IRequest<ExperienciaCalidadListVm>
    {
        public int Id { get; set; }
    }
}





