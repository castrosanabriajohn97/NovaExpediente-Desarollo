// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.GradosAcademicos.Queries.GetListaGradosAcademicos
{
    public class GradosAcademicosListVm
    {
        public IList<GradoAcademicoDto> GradosAcademicos { get; set; }

        public int Count { get; set; }
    }
}
