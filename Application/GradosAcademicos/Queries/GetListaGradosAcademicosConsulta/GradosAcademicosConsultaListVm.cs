// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.GradosAcademicos.Queries.GetListaGradosAcademicosConsulta
{
    public class GradosAcademicosConsultaListVm
    {
        public IList<GradoAcademicoConsultaDto> GradosAcademicos { get; set; }

        public int Count { get; set; }
    }
}
