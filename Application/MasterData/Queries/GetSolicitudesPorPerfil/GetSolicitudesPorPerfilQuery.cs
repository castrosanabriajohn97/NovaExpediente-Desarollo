// EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature.
﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaExpediente.Application.MasterData.Queries.GetSolicitudesPorPerfil
{
    public class GetSolicitudesPorPerfilQuery : IRequest<SolicitudesPorPerfilVm>
    {
        public List<string> Roles { get; set; }
        public string Categoria { get; set; }
    }
}
