// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.Buses.Queries.GetListaBus
{
    public class BusListVm
    {
        public IList<BusDto> Buses { get; set; }

        public int Count { get; set; }
    }
}
