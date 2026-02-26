// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.ExperienciasERP.Queries.GetListaExperienciasERP
{
   public class GetExperienciaERPListQuery : IRequest<ExperienciaERPListVm>
    {
        public int Id { get; set; }
    }
}





