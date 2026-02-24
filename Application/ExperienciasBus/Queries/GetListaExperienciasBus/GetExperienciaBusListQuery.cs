// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.ExperienciasBus.Queries.GetListaExperienciasBus
{
   public class GetExperienciaBusListQuery : IRequest<ExperienciaBusListVm>
    {
        public int Id { get; set; }
    }
}





