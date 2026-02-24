// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.CentrosEstudios.Queries.GetListaCentroEstudio
{
    public class CentroEstudioListVm
    {
        public IList<CentroEstudioDto> CentrosEstudios { get; set; }

        public int Count { get; set; }
    }
}
