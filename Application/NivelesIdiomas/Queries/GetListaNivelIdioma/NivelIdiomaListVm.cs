// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.NivelesIdiomas.Queries.GetListaNivelIdioma
{
    public class NivelIdiomaListVm
    {
        public IList<NivelIdiomaDto> NivelIdioma { get; set; }

        public int Count { get; set; }
    }
}
