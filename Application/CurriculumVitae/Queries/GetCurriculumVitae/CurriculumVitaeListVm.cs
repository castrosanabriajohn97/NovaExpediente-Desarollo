// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.CurriculumVitae.Queries.GetCurriculumVitae
{
    public class CurriculumVitaeListVm
    {
        public List<CurriculumVitaeDto> CurriculumVitaes { get; set; }
        public int count;
    }
}
