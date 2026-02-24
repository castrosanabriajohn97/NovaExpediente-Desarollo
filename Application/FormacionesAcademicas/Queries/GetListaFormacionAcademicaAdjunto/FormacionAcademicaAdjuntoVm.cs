// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.FormacionesAcademicas.Queries.GetListaFormacionAcademicaAdjunto
{
    public class FormacionAcademicaAdjuntoVm
    {
        public IList<FormacionAcademicaAdjuntoDto> FormacionesAcademicas { get; set; }

        public int Count { get; set; }
    }
}
