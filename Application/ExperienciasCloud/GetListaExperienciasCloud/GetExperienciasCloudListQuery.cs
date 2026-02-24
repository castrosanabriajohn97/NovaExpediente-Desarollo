// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.ExperienciasCloud.Queries.GetListaExperienciasCloud
{
   public class GetExperienciasCloudListQuery : IRequest<ExperienciasCloudListVm>
    {
        public int Id { get; set; }
    }
}





