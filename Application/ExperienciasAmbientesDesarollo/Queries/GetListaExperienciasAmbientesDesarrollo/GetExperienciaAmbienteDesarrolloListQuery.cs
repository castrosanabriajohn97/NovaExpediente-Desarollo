// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.ExperienciasAmbientesDesarollo.Queries.GetListaExperienciasAmbientesDesarrollo
{
   public class GetExperienciaAmbienteDesarrolloListQuery : IRequest<ExperienciaAmbienteDesarrolloListVm>
    {
        public int Id { get; set; }
    }
}





