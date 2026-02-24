// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using System.Collections.Generic;

namespace NovaExpediente.Application.Clouds.Queries.GetListaCloud
{
    public class CloudVm
    {
        public IList<CloudDto> Clouds { get; set; }

        public int Count { get; set; }
    }
}
