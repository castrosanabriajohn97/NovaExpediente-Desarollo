// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaExpediente.Application.MasterData.Queries.GetExperienciaActual
{
    public class GetExperienciaActualQuery : IRequest<ExperienciaActualVm>
    {
        public int IdColaborador { get; set; }
        public int IdCatalogo { get; set; }
        public int IdInstanciaCatalogo { get; set; }
    }
}
