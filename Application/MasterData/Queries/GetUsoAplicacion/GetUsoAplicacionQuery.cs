// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaExpediente.Application.MasterData.Queries.GetUsoAplicacion
{
    public class GetUsoAplicacionQuery : IRequest<UsoAplicacionVm>
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
