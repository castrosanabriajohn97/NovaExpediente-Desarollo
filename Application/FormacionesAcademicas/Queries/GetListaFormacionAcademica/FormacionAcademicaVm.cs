// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.FormacionesAcademicas.Queries.GetListaFormacionAcademica
{ 
    public class FormacionAcademicaVm
{
        public IList<FormacionAcademicaDto> FormacionesAcademicas { get; set; }

        public int Count { get; set; }
    }
}
