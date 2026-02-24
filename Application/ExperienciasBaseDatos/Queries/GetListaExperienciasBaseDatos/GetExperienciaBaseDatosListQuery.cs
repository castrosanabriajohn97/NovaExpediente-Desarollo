// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.ExperienciasBaseDatos.Queries.GetListaExperienciasBaseDatos
{
   public class GetExperienciaBaseDatosListQuery : IRequest<ExperienciaBaseDatosListVm>
    {
        public int Id { get; set; }
    }
}





