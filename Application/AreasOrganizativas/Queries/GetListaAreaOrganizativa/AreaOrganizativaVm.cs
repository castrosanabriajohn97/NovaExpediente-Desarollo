// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NovaExpediente.Application.AreasOrganizativas.Queries.GetListaAreaOrganizativa
{
    public class AreaOrganizativaVm
    {
        public IList<AreaOrganizativaDto> areaOrganizativas { get; set; }

        public int Count { get; set; }
    }
}
