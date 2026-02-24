// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.ExperienciasBPM.Queries.GetListaExperienciasBPM
{
   public class GetExperienciaBPMListQuery : IRequest<ExperienciaBPMListVm>
    {
        public int Id { get; set; }
    }
}





