// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.ExperienciasLenguajes.Queries.GetListaExperienciasLenguajes
{
   public class GetExperienciaLenguajeListQuery : IRequest<ExperienciaLenguajeListVm>
    {
        public int Id { get; set; }
    }
}





