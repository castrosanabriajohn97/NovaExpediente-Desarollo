// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.ExperienciasInfraestructura.Queries.GetListaExperienciasInfraestructura
{
   public class GetExperienciaInfraestructuraListQuery : IRequest<ExperienciaInfraestructuraListVm>
    {
        public int Id { get; set; }
    }
}





