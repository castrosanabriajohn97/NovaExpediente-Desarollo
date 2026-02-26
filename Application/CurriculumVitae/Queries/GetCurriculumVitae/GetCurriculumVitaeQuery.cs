// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;

namespace NovaExpediente.Application.CurriculumVitae.Queries.GetCurriculumVitae
{
    public class GetCurriculumVitaeQuery : IRequest<CurriculumVitaeListVm>
    {
        public int IdColaborador { get; set; }
    }
}
