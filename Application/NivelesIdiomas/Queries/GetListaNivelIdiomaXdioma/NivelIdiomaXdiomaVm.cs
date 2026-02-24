// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.NivelesIdiomas.Queries.GetListaNivelIdiomaXdioma
{
    public class NivelIdiomaVm
    {
        public IList<NivelIdiomaXdiomaDto> NivelesIdioma { get; set; }

        public int Count { get; set; }
    }
}
