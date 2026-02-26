// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaExpediente.Application.MasterData.Queries.GetDetalleSolicitud
{
    public class GetDetalleSolicitudQuery : IRequest<DetalleSolicitudVm>
    {
        public int Id { get; set; }
    }
}
