// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.ExperienciasTecnologias.Queries.GetListaExperienciasTecnologias
{
   public class GetExperienciaTecnologiaListQuery : IRequest<ExperienciaTecnologiaListVm>
    {
        public int Id { get; set; }
    }
}





